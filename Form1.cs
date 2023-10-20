using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Concatenation_Of_Two_Words
{
    public partial class Form1 : Form
    {
        private ArrayList words = new ArrayList();
        private ArrayList concatenatedWords = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = WordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Please enter a word in the TextBox.", "Error");
                return;
            }

            if (words.Contains(word))
            {
                MessageBox.Show("This word has already been added.", "Error");
                return;
            }

            if (words.Count > 0 && words.Contains(word))
            {
                MessageBox.Show("This word is already in the ComboBox.", "Error");
                return;
            }

            words.Add(word);

            WordTextBox.Clear();
           
            Word1ComboBox.Items.Add(word);
            Word2ComboBox.Items.Add(word);
            concatenatedWords.Add(word);

            MessageBox.Show("Word added successfully.", "Success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Remove1RadioButton.Checked)
            {
                if (Word1ComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a word to remove.", "Error");
                    return;
                }

                if (Word1ComboBox.SelectedItem != null)
                {
                    string selectedWord = Word1ComboBox.SelectedItem.ToString();
                    Word1ComboBox.Items.Remove(selectedWord);
                    concatenatedWords.Remove(selectedWord);
                }

                if (Word2ComboBox.SelectedItem != null)
                {
                    string selectedWord = Word2ComboBox.SelectedItem.ToString();
                    Word2ComboBox.Items.Remove(selectedWord);
                    concatenatedWords.Remove(selectedWord);
                }

                MessageBox.Show("Word removed successfully.", "Success");
            }

            else if (Remove2RadioButton.Checked)
            {
                if (Word2ComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a word to remove.", "Error");
                    return;
                }

                if (Word1ComboBox.SelectedItem != null)
                {
                    string selectedWord = Word1ComboBox.SelectedItem.ToString();
                    Word1ComboBox.Items.Remove(selectedWord);
                    concatenatedWords.Remove(selectedWord);
                }

                if (Word2ComboBox.SelectedItem != null)
                {
                    string selectedWord = Word2ComboBox.SelectedItem.ToString();
                    Word2ComboBox.Items.Remove(selectedWord);
                    concatenatedWords.Remove(selectedWord);
                }

                MessageBox.Show("Word removed successfully.", "Success");
            }

            else
            {
                if (Word1ComboBox.SelectedItem == null || Word2ComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select words from both ComboBoxes to concatenate.", "Error");
                    return;
                }

                string word1 = Word1ComboBox.SelectedItem.ToString();
                string word2 = Word2ComboBox.SelectedItem.ToString();

                if (word1 == word2)
                {
                    MessageBox.Show("Please select different words from both ComboBoxes.", "Error");
                    return;
                }

                string concatenatedWord = word1 + word2;

                label5.Text = concatenatedWord;
                MessageBox.Show("Words concatenated successfully.", "Success");

            
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Remove1RadioButton.Checked)
            {
                btnConcatenate.Text = "Remove Item";
            }
            else
            { btnConcatenate.Text = "Concatenate"; }
        }

        private void Remove2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Remove2RadioButton.Checked)
            {
                btnConcatenate.Text = "Remove Item";
            }
            else
            { btnConcatenate.Text = "Concatenate"; }
        }
    }
}


