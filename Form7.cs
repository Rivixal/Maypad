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
            string str = searchForm.richTextBox1.Text;

            if (String.IsNullOrEmpty(str) || String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введите текст");
            }
            else
            {
                if (str.IndexOf(textBox1.Text) != -1)
                {

                    //MessageBox.Show("Found");
                    searchForm.richTextBox1.SelectionStart = str.IndexOf(textBox1.Text);
                    searchForm.richTextBox1.SelectionLength = textBox1.Text.Length;
                    searchForm.richTextBox1.SelectionBackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Не найденно");
                }
            }
        }


    }
 }