using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form8 : Form
    {
        Form1 sc;
        public Form8()
        {
            InitializeComponent();
            sc = (Form1)this.Owner;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            sc.richTextBox1.Select();
            sc.richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Regular);
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            sc.richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Underline);
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Underline);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Bold);
            sc.richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Italic);
            sc.richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Italic);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Strikeout);
            sc.richTextBox1.SelectionFont = new Font(sc.richTextBox1.Font, FontStyle.Strikeout);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                sc.richTextBox1.Select();
                sc.richTextBox1.SelectionColor = selectedColor;
                button9.ForeColor = selectedColor;
                richTextBox1.ForeColor = selectedColor;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                sc.richTextBox1.Select();
                sc.richTextBox1.SelectionBackColor = selectedColor;
                button6.BackColor = selectedColor;
                richTextBox1.BackColor = selectedColor;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            sc.richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionColor = Color.Black;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            richTextBox1.SelectionBackColor = Color.Transparent;
            sc.richTextBox1.SelectionBackColor = Color.Transparent;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            string str = sc.richTextBox1.Text;
            sc.richTextBox1.SelectAll();
            sc.richTextBox1.SelectionBackColor = sc.richTextBox1.ForeColor;
            sc.richTextBox1.SelectionBackColor = sc.richTextBox1.BackColor;
            richTextBox1.SelectionBackColor = sc.richTextBox1.ForeColor;
            richTextBox1.SelectionBackColor = sc.richTextBox1.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            string str = sc.richTextBox1.Text;
            sc.richTextBox1.Select();
            sc.richTextBox1.SelectionBackColor = sc.richTextBox1.ForeColor;
            richTextBox1.Select();
            richTextBox1.SelectionBackColor = sc.richTextBox1.ForeColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            string str = sc.richTextBox1.Text;
            sc.richTextBox1.Select();
            sc.richTextBox1.SelectionBackColor = sc.richTextBox1.BackColor;
            richTextBox1.Select();
            richTextBox1.SelectionBackColor = sc.richTextBox1.BackColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            button13.Text = DateTime.Now.ToString();
            sc.richTextBox1.Text += DateTime.Now;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            if (sc.richTextBox1.SelectionLength > 0)
            {
                sc.richTextBox1.Copy();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            if (sc.richTextBox1.SelectionLength > 0)
            {
                sc.richTextBox1.Cut();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            sc.richTextBox1.Paste();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            sc.richTextBox1.Undo();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            sc.richTextBox1.SelectAll();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sc = (Form1)this.Owner;
            if (sc.richTextBox1.SelectionLength > 0)
            {
                sc.richTextBox1.SelectedText = "";
            }
        }
    }
}
