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
        
        

        
        


        //'Analyse' button that the user presses to analyse the text (word count, character count, frequency ect..)
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text != "")
            {

                this.richTextBox1.Focus();
                this.richTextBox1.Clear();
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


