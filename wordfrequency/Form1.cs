﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace wordfrequency
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        

        //This function counts the number of words in the user input
        // input :
        // input - user text 
        // output:
        // int - number of words
        private int WordCount(string input)
        {
            //Seperate all the words using spaces
            string[] w = input.Split(' ');
        
            return w.Length;
        }


        //Count the number of characters including spaces and punctionation
        // input :
        // value - user text 
        // output:
        // int - number of characters
        static int CountChars(string value)
        {

            return value.Length;

        }
        private void GetWordsFromFile(string fileName, Dictionary<string, int> listOfWords,
            Dictionary<string, int> rootWords,
            Dictionary<string, string> family)
        {
            // Open the text file an read by line
            using (StreamReader file = new StreamReader(fileName))
            {
                string line;

                string rootWord = "";
                //For each line in the text file seperate the word from the count and findout if the word is rooot word or not
                //For rootwords the words starts from the begining of the line for other words the word starts after that tab
                while ((line = file.ReadLine()) != null)

                {

                    string[] parts = line.Split(' ');
                    if (string.IsNullOrEmpty(line)) break;
                    char f = line[0];
                    string word;
                    word = parts[0];
                    word = Regex.Replace(word, "[ \n\r\t]+", "");
                    //If the word is a root word then add it in the rootWords dictionary and remember it in the variable rootWord
                    if (!((f == '\t') || (f == ' ')))

                    {

                        family.Add(word, word);
                        rootWords.Add(word, Convert.ToInt32(parts[1]));
                        rootWord = word;

                    }
                    // If the word is not a rootword then add it in the dicitonary family with its 'rootword' that we rememebred also 
                    //Also add the word in the list of all the words 
                    else
                    {


                        family.Add(word, rootWord);
                        listOfWords.Add(word, Convert.ToInt32(parts[1]));
                    }
                }
                file.Close();
            }
        }
        private void CountWordsInText(string content, Dictionary<string, int> words,
       Dictionary<string, int> rootwords,
           Dictionary<string, string> family)

        {
            //serpertate the string into words
            var wordPattern = new Regex(@"\w+");
            //for each word in the user input covert into a uppercase for robustness

            foreach (Match match in wordPattern.Matches(content.ToUpper()))
            {
                int currentCount = 0;
                string root = string.Empty;
                //Get the current count of the word from the dictionary
                words.TryGetValue(match.Value, out currentCount);
                currentCount++;
                //If the word is found then inicrament the count by one 
                words[match.Value] = currentCount;
                currentCount = 0;

                //Get the root word for the given word
                if (family.TryGetValue(match.Value, out root))
                {
                    //root = family[match.Value];
                    //  Get the count of the rootword from the dictionary 
                    if (rootwords.TryGetValue(root, out currentCount))
                    {

                        currentCount++;
                        //inrament the count of root word by one
                        rootwords[root] = currentCount;
                    }
                }
            }
        }


        //'Analyse' button that the user presses to analyse the text (word count, character count, frequency ect..)
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.userTextInsert.Text != "")
            {

                this.userTextInsert.Focus();
                //this.richTextBox1.Clear();
                //words - dictionary with words and their count 
                //The word is the key and value is the count
                Dictionary<string, int> words = new Dictionary<string, int>();
                words.Clear();
                //familyWords - dictionary with words and their roots
                //The word is the key and the value is the root word
                Dictionary<string, string> familyWords = new Dictionary<string, string>();
                familyWords.Clear();
                //familyCount - dictionary with root words and their counts
                //The rootword is the key and the value is the count
                Dictionary<string, int> familyCount = new Dictionary<string, int>();
                familyCount.Clear();
                //Load all the words from different textfiles.
                //Text file names are basewrd<index>.txt
                //Wher inex is 1 - 34
                for (int i = 1; i <= 34; ++i)
                {
                    string inputfile = "basewrd";
                    string ext = ".txt";
                    inputfile = string.Concat(inputfile, i.ToString(), ext);
                    GetWordsFromFile(inputfile, words, familyCount, familyWords);//load the words from the text file in different dictionarys
                }
                wordCountDisplay.AppendText("Word count: ");
               
               
                //Display word count in text box
                int numberofwords = WordCount(userTextInsert.Text);
                string wordCount = Convert.ToString(numberofwords);
                wordCountDisplay.AppendText(wordCount);
                //Display character count in text box

                characterCountDisplay.Clear();
                characterCountDisplay.AppendText("Char Count: ");

                int numberofchars = CountChars(userTextInsert.Text);
                string Countchars = Convert.ToString(numberofchars);
                characterCountDisplay.AppendText(Countchars);

                //Calculate frequencies for words 
                CountWordsInText(userTextInsert.Text, words, familyCount, familyWords);


                var sortedwords = from item in words
                                  orderby item.Value descending
                                  select item;

                wordFrequency.Clear();
                //Display word frequencies sorted on counts. Words with o count will not be displayed
                foreach (var item in sortedwords)
                {
                    if (item.Value > 0)
                    {

                        wordFrequency.AppendText(item.Key);
                        wordFrequency.AppendText("\t");
                         
                        if (item.Key.ToString().Length < 8)
                        {
                            wordFrequency.AppendText("\t");
                        }
                        wordFrequency.AppendText(item.Value.ToString());
                        wordFrequency.AppendText("\t");

                        double f = Convert.ToDouble(Convert.ToDouble(item.Value) * 100.0 / Convert.ToDouble(numberofwords));//Truncase result to two decimal places
                        string s = string.Format("{0:N2}%", f);
                        wordFrequency.AppendText(s);
                        wordFrequency.AppendText(Environment.NewLine);

                    }
                }

                //Display root words and their frequencies. Words with 0 count will not be displayed
                var sortedRoots = from item in familyCount
                                  orderby item.Value descending
                                  select item;
                familyFrequency.Clear();
                foreach (var item in sortedRoots)
                {

                    if (item.Value > 0)
                    {
                        familyFrequency.AppendText(item.Key);

                        familyFrequency.AppendText("\t");
                        if (item.Key.ToString().Length < 8)
                        {
                            familyFrequency.AppendText("\t");
                        }
                        familyFrequency.AppendText(item.Value.ToString());
                        familyFrequency.AppendText("\t");
                        double f = Convert.ToDouble(Convert.ToDouble(item.Value) * 100.0 / Convert.ToDouble(numberofwords));
                        string s = string.Format("{0:N2}%", f);
                        familyFrequency.AppendText(s);
                        familyFrequency.AppendText(Environment.NewLine);
                    }
                }

            }
            else
            {
                MessageBox.Show("There is no text to analyse,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.userTextInsert.Focus();
            }
        }
        // Pressing this button will clear all the text boxes. 
        private void Button2_Click(object sender, EventArgs e)
        {
            this.userTextInsert.Clear();
            this.wordCountDisplay.Clear();
            this.characterCountDisplay.Clear();
            familyFrequency.Clear();
            wordFrequency.Clear();

        }

        private void wordCountDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    } 
} 


