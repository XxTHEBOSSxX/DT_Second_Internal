using System;
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


        //'Analyse' button that the user presses to analyse the text (word count, character count, frequency ect..)
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text != "")
            {

                this.richTextBox1.Focus();
                
                //Display character count in text box

                richTextBox3.Clear();
                richTextBox3.AppendText("Char Count: ");

                int numberofchars = CountChars(richTextBox1.Text);
                string Countchars = Convert.ToString(numberofchars);
                richTextBox3.AppendText(Countchars);
            }
            else
            {
                MessageBox.Show("Please enter propper text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.richTextBox1.Focus();
            }
        }
        // Pressing this button will clear all the text boxes. 
        private void Button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.richTextBox2.Clear();
            this.richTextBox3.Clear();
            familyFrequency.Clear();
            wordFrequency.Clear();

        }
    } 
} 


