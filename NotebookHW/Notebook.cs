using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace NotebookHW
{
    public partial class Notebook : Form
    {

        public Notebook()
        {
            InitializeComponent();
            Init();
        }

        public int FontSize = 10;
        public System.Drawing.FontStyle FontStyle = FontStyle.Regular;
        public System.Drawing.Color FontColor = Color.Black;
        public string FontOfText = "Arial";
        public string filename;
        public bool isFileChanged;
        public FontSettings FontSettings;
        private void Init()
        {
            filename = "";
            MainTextBox.Font = new Font(FontOfText, FontSize, FontStyle);
            FontSize = 10;
            isFileChanged = false;
            FontSettings = new FontSettings();
            UpdateTitle();
        }

        private void AboutProgramm(object sender, EventArgs e)
        {
            using (var AboutProgramm = new AboutProgramm())
            {
                AboutProgramm.ShowDialog();
            }
        }

        private void FontChange(object sender, EventArgs e)
        {
            FontSettings.FontColor = FontColor;
            FontSettings.FontOfText = FontOfText;
            FontSettings.FontSize = FontSize;
            FontSettings.FontStyle = FontStyle;
            FontSettings.ShowDialog();
        }

        private void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }

        private void CreateNewFile(object sender, EventArgs e)
        {
            SaveUnsaved();
            MainTextBox.Text = "";
            filename = "";
            isFileChanged = false;
            UpdateTitle();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            SaveUnsaved();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    MainTextBox.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл");
                }
            }
            UpdateTitle();
        }
        private void SaveFile(string _filename)
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
                StreamWriter sw = new StreamWriter(_filename + ".txt");
                sw.Write(MainTextBox.Text);
                sw.Close();
                isFileChanged = false;
                UpdateTitle();
            }
            catch
            {
                MessageBox.Show("Невозможно соранить файл");
            }
        }
        private void TxtChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace("*", "");
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }
        private void UpdateTitle()
        {
            if (filename != "")
            {
                this.Text = filename + " -  Блокнот";
            }
            else
            {
                this.Text = "Безымянный -  Блокнот";
            }
        }

        private void ExitProgramm(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveUnsaved()
        {
            if (isFileChanged)
            {
                DialogResult res = MessageBox.Show("Сохранить изменения?", "Сохранение изменений", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }

        private void Copy()
        {
            if (MainTextBox.SelectedText.Length != 0)
            {
                Clipboard.SetText(MainTextBox.SelectedText);
            }
        }

        private void Cut()
        {
            if (MainTextBox.SelectedText.Length != 0)
            {
                Clipboard.SetText(MainTextBox.Text.Substring(MainTextBox.SelectionStart, MainTextBox.SelectionLength));
                MainTextBox.Text = MainTextBox.Text.Remove(MainTextBox.SelectionStart, MainTextBox.SelectionLength);
            }
        }

        private void Paste()
        {
            MainTextBox.Text = MainTextBox.Text.Substring(0, MainTextBox.SelectionStart) + Clipboard.GetText() + MainTextBox.Text.Substring(MainTextBox.SelectionStart, MainTextBox.Text.Length - MainTextBox.SelectionStart);
        }

        private void CopyText(object sender, EventArgs e)
        {
            Copy();
        }

        private void CutText(object sender, EventArgs e)
        {
            Cut();
        }

        private void PasteText(object sender, EventArgs e)
        {
            Paste();
        }

        private void FormCLosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsaved();
        }

        private void Print(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDialog1.Document.Print();
        }

        private void Focus(object sender, EventArgs e) // изменения текста на основной форме
        {
            if (FontSettings != null && FontSettings.ToSave == true)
            {
                FontSize = FontSettings.FontSize;
                FontStyle = FontSettings.FontStyle;
                FontOfText = FontSettings.FontOfText;
                FontColor = FontSettings.FontColor;
                if (MainTextBox.SelectedText.Length == 0)
                {
                    MainTextBox.Font = new Font(FontOfText, FontSize, FontStyle);
                    MainTextBox.ForeColor = FontColor;
                }
                else
                {
                    MainTextBox.SelectionFont = new Font(FontOfText, FontSize, FontStyle);
                    MainTextBox.SelectionColor = FontColor;
                }
                FontSettings.Close();
            }
        }
    }
}
