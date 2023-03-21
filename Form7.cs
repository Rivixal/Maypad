using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form7 : Form
    {
        Form1 searchForm;
        public Form7()
        {
            InitializeComponent();
            searchForm = (Form1)this.Owner;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_load(object sender, EventArgs e)
        {
            Form1 searchForm = new Form1();
        }

        private void FindrichtextBox(object sender, EventArgs e)
        {
            searchForm = (Form1)this.Owner;
            string str = searchForm.richTextBox1.Text;
            if (String.IsNullOrEmpty(str) || String.IsNullOrEmpty(textBox1.Text))
            {
                toolStripStatusLabel1.Text = "Не удалось найти текст! Поле поиска текста не может быть пустым.";
            }
            else
            {
                if (str.IndexOf(textBox1.Text) != -1)
                {
                    bool caseSensitive = checkBox1.Checked;
                    StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
                    int start = 0;
                    int end = searchForm.richTextBox1.Text.LastIndexOf(textBox1.Text, comparison);
                    searchForm.richTextBox1.Select();
                    toolStripStatusLabel1.Text = "Поиск успешно выполнен!";

                    while (start <= end)
                    { 

                        start = searchForm.richTextBox1.Find(textBox1.Text, start, searchForm.richTextBox1.TextLength, RichTextBoxFinds.None);
                        searchForm.richTextBox1.SelectionBackColor = Color.Cyan;
                        searchForm.richTextBox1.Select(start, textBox1.TextLength);
                        searchForm.richTextBox1.SelectionStart = start;
                        searchForm.richTextBox1.SelectionLength = textBox1.Text.Length;

                       start++;
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = "По вашему запросу ничего не найденно!";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchForm = (Form1)this.Owner;
            string str = searchForm.richTextBox1.Text;
            searchForm.richTextBox1.SelectAll();
            searchForm.richTextBox1.SelectionBackColor = searchForm.richTextBox1.ForeColor;
            searchForm.richTextBox1.SelectionBackColor = searchForm.richTextBox1.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            string replaceText = textBox2.Text;

            if (string.IsNullOrEmpty(replaceText))
            {
                toolStripStatusLabel1.Text = "Не удалось заменить текст! Поле замены текста не может быть пустым.";
                return;
            }
            // Заменить найденный текст
            if (searchForm.richTextBox1.Text.Contains(searchText))
            {
                searchForm.richTextBox1.Text = searchForm.richTextBox1.Text.Replace(searchText, replaceText);
                toolStripStatusLabel1.Text = "Замена текста успешно примененна!";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
 
        }
    }
 }