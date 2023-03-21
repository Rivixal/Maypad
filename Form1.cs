using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Text.Encodings.Web;

namespace notepad
{
    public partial class Form1 : Form
    {
        public string filename;
        public bool isFileChanged;

        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += RefreshTime;
            timer1.Enabled = true;
            Init();
        }

        public void Init()
        {
            filename = "";
            UpdateTextWithTitle();
        }

        public void RefreshTime(object sender, EventArgs e)
        {
            toolStripStatusLabel12.Text = DateTime.Now.ToString("dd.MM.yy HH:mm:ss");
        }

        public void CreateNewDocument(object sender, EventArgs e)
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Внимание! Внесённые вами данные не сохранены, хотите сейчас сохранить?", "Сохранение файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
                if (result == DialogResult.No)
                {

                }
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                richTextBox1.Text = "";
                filename = "";
                isFileChanged = false;
                UpdateTextWithTitle();
            }
        }

        public void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            SaveUnsavedFile();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                }
                catch
                {
                    return;
                }
            }
            UpdateTextWithTitle();
        }

        public void SaveFile(string _filename)
        {
            if (_filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename);
                sw.Write(richTextBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;
            }
            catch
            {
                return;
            }
        }

        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }
        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile(filename);
        }

        public void OntextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "* " + this.Text;
            }
            toolStripStatusLabel2.Text = $"Строка: {richTextBox1.Lines.Length}";
            toolStripStatusLabel3.Text = $"Столбец: {richTextBox1.TextLength}";
            toolStripStatusLabel8.Text = InputLanguage.CurrentInputLanguage.Culture.Name;
            toolStripStatusLabel8.Text = InputLanguage.CurrentInputLanguage.LayoutName;
            richTextBox1.Top = 0;
        }
        public void UpdateTextWithTitle()
        {
            if (filename != "")
                this.Text = filename + " - Maypad";
            else
                this.Text = "Безымянный - Maypad";
        }

        public void SaveUnsavedFile()
        {

        }

        private void On(object sender, FormClosedEventArgs e)
        {

        }


        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", 18, FontStyle.Regular);
            menuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel3.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel6.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel7.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel8.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel9.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel10.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel11.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel12.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            contextMenuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            contextMenuStrip1.BackColor = Color.Black;
            contextMenuStrip1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.Black;
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel3.ForeColor = Color.White;
            toolStripStatusLabel6.ForeColor = Color.White;
            toolStripStatusLabel7.ForeColor = Color.White;
            toolStripStatusLabel8.ForeColor = Color.White;
            toolStripStatusLabel9.ForeColor = Color.White;
            toolStripStatusLabel10.ForeColor = Color.White;
            toolStripStatusLabel11.ForeColor = Color.White;
            toolStripStatusLabel12.ForeColor = Color.White;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.ForeColor;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", 18, FontStyle.Regular);
            menuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel3.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel6.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel7.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel8.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel9.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel10.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel11.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel12.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            contextMenuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.ForeColor = Color.Black;
            statusStrip1.BackColor = Color.White;
            toolStripStatusLabel2.ForeColor = Color.Black;
            toolStripStatusLabel3.ForeColor = Color.Black;
            toolStripStatusLabel6.ForeColor = Color.Black;
            toolStripStatusLabel7.ForeColor = Color.Black;
            toolStripStatusLabel8.ForeColor = Color.Black;
            toolStripStatusLabel9.ForeColor = Color.Black;
            toolStripStatusLabel10.ForeColor = Color.Black;
            toolStripStatusLabel11.ForeColor = Color.Black;
            toolStripStatusLabel12.ForeColor = Color.Black;
            toolStripStatusLabel2.BackColor = Color.Transparent;
            toolStripStatusLabel3.BackColor = Color.Transparent;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.ForeColor;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
        }

        private void темнаяHackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", 18, FontStyle.Regular);
            menuStrip1.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel2.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel3.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel6.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel7.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel8.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel9.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel10.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel11.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel12.Font = new Font("Consolas", 9, FontStyle.Regular);
            contextMenuStrip1.Font = new Font("Consolas", 9, FontStyle.Regular);
            richTextBox1.ForeColor = Color.LimeGreen;
            richTextBox1.BackColor = Color.Black;
            contextMenuStrip1.BackColor = Color.Black;
            contextMenuStrip1.ForeColor = Color.LimeGreen;
            statusStrip1.BackColor = Color.Black;
            toolStripStatusLabel2.ForeColor = Color.LimeGreen;
            toolStripStatusLabel3.ForeColor = Color.LimeGreen;
            toolStripStatusLabel6.ForeColor = Color.LimeGreen;
            toolStripStatusLabel7.ForeColor = Color.LimeGreen;
            toolStripStatusLabel8.ForeColor = Color.LimeGreen;
            toolStripStatusLabel9.ForeColor = Color.LimeGreen;
            toolStripStatusLabel10.ForeColor = Color.LimeGreen;
            toolStripStatusLabel11.ForeColor = Color.LimeGreen;
            toolStripStatusLabel12.ForeColor = Color.LimeGreen;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.ForeColor;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
        }

        private void темаMSMaydilsielStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", 18, FontStyle.Regular);
            menuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel3.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel6.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel7.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel8.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel9.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel10.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel11.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel12.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            contextMenuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.DarkSlateGray;
            contextMenuStrip1.BackColor = Color.DarkViolet;
            contextMenuStrip1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.DarkViolet;
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel3.ForeColor = Color.White;
            toolStripStatusLabel6.ForeColor = Color.White;
            toolStripStatusLabel7.ForeColor = Color.White;
            toolStripStatusLabel8.ForeColor = Color.White;
            toolStripStatusLabel9.ForeColor = Color.White;
            toolStripStatusLabel10.ForeColor = Color.White;
            toolStripStatusLabel11.ForeColor = Color.White;
            toolStripStatusLabel12.ForeColor = Color.White;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.ForeColor;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
        }

        private void темаErtorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", 18, FontStyle.Regular);
            menuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel3.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel6.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel7.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel8.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel9.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel10.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel11.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel12.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            contextMenuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.DarkOrange;
            contextMenuStrip1.BackColor = Color.SlateGray;
            contextMenuStrip1.ForeColor = Color.Yellow;
            statusStrip1.BackColor = Color.SlateGray;
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel3.ForeColor = Color.White;
            toolStripStatusLabel6.ForeColor = Color.White;
            toolStripStatusLabel7.ForeColor = Color.White;
            toolStripStatusLabel8.ForeColor = Color.White;
            toolStripStatusLabel9.ForeColor = Color.White;
            toolStripStatusLabel10.ForeColor = Color.White;
            toolStripStatusLabel11.ForeColor = Color.White;
            toolStripStatusLabel12.ForeColor = Color.White;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.ForeColor;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
        }

        private void сераяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", 18, FontStyle.Regular);
            menuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel3.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel6.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel7.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel8.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel9.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel10.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel11.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            toolStripStatusLabel12.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            contextMenuStrip1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.DimGray;
            contextMenuStrip1.BackColor = Color.DimGray;
            contextMenuStrip1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.DimGray;
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel3.ForeColor = Color.White;
            toolStripStatusLabel6.ForeColor = Color.White;
            toolStripStatusLabel7.ForeColor = Color.White;
            toolStripStatusLabel8.ForeColor = Color.White;
            toolStripStatusLabel9.ForeColor = Color.White;
            toolStripStatusLabel10.ForeColor = Color.White;
            toolStripStatusLabel11.ForeColor = Color.White;
            toolStripStatusLabel12.ForeColor = Color.White;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.ForeColor;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myFont = new FontDialog();
            if (myFont.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = myFont.Font;
            }
        }

        private void вставитьДатуИВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now;
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText = "";
            }
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void найтиИЗаменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();
            newfrm.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            toolStripStatusLabel12.Text = "**.**.**** **:**";
            toolStripStatusLabel8.Text = InputLanguage.CurrentInputLanguage.Culture.Name;
            toolStripStatusLabel8.Text = InputLanguage.CurrentInputLanguage.LayoutName;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemEventArgs e)
        {

        }

        private void statusStrip1_TextChanged(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_TextChanged(object sender, EventArgs e)
        {

        }

        private void strokiLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void strokiLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Load(object sender, EventArgs e)
        {
            Form7 searchForm = new Form7();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Внимание! Внесённые вами данные не сохранены, хотите сейчас сохранить? ", "Сохранение файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void маштабToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mstandart()
        {

        }

        private void m150()
        {

        }

        private void mstandart(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0f;
            toolStripStatusLabel6.Text = $"Масштаб 100%";
        }

        private void m150(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.5f;
            toolStripStatusLabel6.Text = $"Масштаб 150%";
        }

        private void m200(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 2.0f;
            toolStripStatusLabel6.Text = $"Масштаб 200%";
        }

        private void m250(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 2.5f;
            toolStripStatusLabel6.Text = $"Масштаб 250%";
        }

        private void m300(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 3.0f;
            toolStripStatusLabel6.Text = $"Масштаб 300%";
        }

        private void minus100(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.10f;
            toolStripStatusLabel6.Text = $"Масштаб -350%";
        }


        private void minus80(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.8f;
            toolStripStatusLabel6.Text = $"Масштаб -150%";
        }

        private void minus60(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.6f;
            toolStripStatusLabel6.Text = $"Масштаб -200%";
        }

        private void minus40(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.4f;
            toolStripStatusLabel6.Text = $"Масштаб -250%";
        }

        private void minus20(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.2f;
            toolStripStatusLabel6.Text = $"Масштаб -300%";
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newfrm = new Form3();
            newfrm.Show();
        }

        private void темаNortonCommanderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", 18, FontStyle.Regular);
            menuStrip1.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel2.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel3.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel6.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel7.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel8.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel9.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel10.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel11.Font = new Font("Consolas", 9, FontStyle.Regular);
            toolStripStatusLabel12.Font = new Font("Consolas", 9, FontStyle.Regular);
            contextMenuStrip1.Font = new Font("Consolas", 9, FontStyle.Regular);
            richTextBox1.ForeColor = Color.Aqua;
            richTextBox1.BackColor = Color.Navy;
            menuStrip1.BackColor = Color.Navy;
            menuStrip1.ForeColor = Color.Gold;
            contextMenuStrip1.BackColor = Color.Aqua;
            contextMenuStrip1.ForeColor = Color.Black;
            statusStrip1.BackColor = Color.Black;
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel3.ForeColor = Color.White;
            toolStripStatusLabel6.ForeColor = Color.White;
            toolStripStatusLabel7.ForeColor = Color.White;
            toolStripStatusLabel8.ForeColor = Color.White;
            toolStripStatusLabel9.ForeColor = Color.White;
            toolStripStatusLabel10.ForeColor = Color.White;
            toolStripStatusLabel11.ForeColor = Color.White;
            toolStripStatusLabel12.ForeColor = Color.White;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.ForeColor;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            menuStrip1.RenderMode = ToolStripRenderMode.System;
        }

        private void темаNanoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void масштаб350ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 3.5f;
            toolStripStatusLabel6.Text = $"Масштаб 350%";
        }

        private void найтиИЗаменитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form7 SearchForm = new Form7();
            this.AddOwnedForm(SearchForm);
            SearchForm.Show();
        }

        private void полноэкранныйРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void выходИзПолноэкранногоРежимаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void скрытьСтатусбарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
        }

        private void toolStripStatusLabel8_Click(object sender, EventArgs e)
        {
            string ln = InputLanguage.CurrentInputLanguage.LayoutName;
        }

        private void скрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Visible = false;
            toolStripStatusLabel7.Visible = false;
        }

        private void показатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Visible = true;
            toolStripStatusLabel7.Visible = true;
        }

        private void скрытьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Visible = false;
        }

        private void показатьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Visible = true;
            toolStripStatusLabel7.Visible = true;
        }

        private void скрытьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel6.Visible = false;
            toolStripStatusLabel10.Visible = false;
        }

        private void показатьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel6.Visible = true;
            toolStripStatusLabel10.Visible = true;
        }

        private void скрытьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel9.Visible = false;
            toolStripStatusLabel8.Visible = false;
        }

        private void показатьТекущуюРаскладкуКлавиатурыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void показатьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel9.Visible = true;
            toolStripStatusLabel8.Visible = true;
        }

        private void показатьToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel11.Visible = false;
            toolStripStatusLabel12.Visible = false;
        }

        private void скрытьToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel11.Visible = true;
            toolStripStatusLabel12.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int start = 0;
            //int end = richTextBox1.Text.LastIndexOf(richTextBox1.Text);
            //richTextBox1.SelectAll();

           // while (start < end)
           // {
               // start = richTextBox1.Find(richTextBox1.Text, start, richTextBox1.TextLength, RichTextBoxFinds.None);
               // richTextBox1.SelectionBackColor = Color.Cyan;
               // richTextBox1.Select(start, richTextBox1.TextLength);
                //start++;
           // }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Transparent;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void показатьToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
        }

        private void скрытьToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void uTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(filename, Encoding.BigEndianUnicode);
        }

        private void uTF16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(filename, Encoding.BigEndianUnicode);
        }

        private void aSCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(filename, Encoding.ASCII);
        }

        private void uTF16LEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(filename, Encoding.Unicode);
        }

        private void настроитьФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                richTextBox1.BackColor = selectedColor;
                richTextBox1.SelectionBackColor = richTextBox1.ForeColor;
                richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            }
        }

        private void настроитьЦветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                richTextBox1.Select();
                richTextBox1.ForeColor = selectedColor;
            }
        }

        private void вызватьПолныйПанельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При сохранения текстового документа с форматированием текста, изменения не будут сохраненны. В ближайших версиях мы скоро исправим этот недочет.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Form8 sc = new Form8();
            this.AddOwnedForm(sc);
            sc.Show();
        }

        private void почеркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }

        private void жирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void курсивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void зачеркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Strikeout);
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                richTextBox1.Select();
                richTextBox1.SelectionColor = selectedColor;
            }
        }

        private void выделитьТекстЦветомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                richTextBox1.Select();
                richTextBox1.SelectionBackColor = selectedColor;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void предупреждениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При сохранения текстового документа с форматированием текста, изменения не будут сохраненны. В ближайших версиях мы скоро исправим этот недочет.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

