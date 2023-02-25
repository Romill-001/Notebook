using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookHW
{
    public partial class FontSettings : Form
    {
        public int FontSize = 10;
        public System.Drawing.FontStyle FontStyle = FontStyle.Regular;
        public string FontOfText = "Arial";
        public System.Drawing.Color FontColor;
        public bool ToSave, SizeFlag, FontFlag, OutlineFlag;
        public int indSize;
        public int indOutline;
        public int indFont;
        public int value;

        public FontSettings()
        {
            InitializeComponent();
            SizeTextBox.Text = (string)SizeListBox.Items[indSize];
            OutlineTextBox.Text = (string)OutlineListBox.Items[indOutline];
            FontTextBox.Text = (string)FontListBox.Items[indFont];
        }

        private void CancelClick(object sender, EventArgs e)
        {
            ToSave = false;
            Close();
        }

        private void OkClick(object sender, EventArgs e)
        {
            SizeError();
            OutlineError();
            FontError();
            if (SizeFlag && OutlineFlag && FontFlag)
            {
                ToSave = true;
                Close();
            }
        }

        private void FontSIzeChange2(object sender, EventArgs e)
        {
            if (int.TryParse(SizeTextBox.Text, out _) == true)
            {
                AbsSize();
                SampleLableToShow.Font = new Font(SampleLableToShow.Font.FontFamily, value, SampleLableToShow.Font.Style);
                FontSize = value;
                indSize = SizeListBox.Items.IndexOf(FontSize);
            }
        }

        private void OutlineChange2(object sender, EventArgs e)
        {
            switch (OutlineTextBox.Text.ToString())
            {
                case "обычный":
                    SampleLableToShow.Font = new Font(SampleLableToShow.Font.FontFamily, int.Parse(SizeTextBox.Text.ToString()), FontStyle.Regular);
                    break;
                case "курсив":
                    SampleLableToShow.Font = new Font(SampleLableToShow.Font.FontFamily, int.Parse(SizeTextBox.Text.ToString()), FontStyle.Italic);
                    break;
                case "полужирный":
                    SampleLableToShow.Font = new Font(SampleLableToShow.Font.FontFamily, int.Parse(SizeTextBox.Text.ToString()), FontStyle.Bold);
                    break;
                case "подчёркнутый текст":
                    SampleLableToShow.Font = new Font(SampleLableToShow.Font.FontFamily, int.Parse(SizeTextBox.Text.ToString()), FontStyle.Underline);
                    break;
            }
            FontStyle = SampleLableToShow.Font.Style;
            indOutline = OutlineListBox.Items.IndexOf(SampleLableToShow.Font.Style);
        }

        private void FontChange2(object sender, EventArgs e)
        {
            SampleLableToShow.Font = new Font(FontTextBox.Text.ToString(), int.Parse(SizeTextBox.Text.ToString()), SampleLableToShow.Font.Style);
            FontOfText = FontTextBox.Text.ToString();
            indFont = FontListBox.Items.IndexOf(FontTextBox.Text.ToString());
        }

        private void SizeValueChange(object sender, EventArgs e)
        {
            SizeTextBox.Text = SizeListBox.SelectedItem.ToString();
        }

        private void FontValueChange(object sender, EventArgs e)
        {
            FontTextBox.Text = FontListBox.SelectedItem.ToString();
        }

        private void OutlineValueChange(object sender, EventArgs e)
        {
            OutlineTextBox.Text = OutlineListBox.SelectedItem.ToString();
        }

        private void SizeError()
        {
            if (int.TryParse(SizeTextBox.Text, out _) != true)
            {
                MessageBox.Show("Размер текста должен быть числом", "Шрифт", MessageBoxButtons.OK, MessageBoxIcon.Question);
                SizeFlag = false;
            }
            else
            {
                SizeFlag = true;
            }
        }


        private void OutlineError()
        {
            int count = 0;
            for (int i = 0; i < OutlineListBox.Items.Count; i++)
            {
                if (OutlineListBox.Items[i].ToString().ToLower() == OutlineTextBox.Text.ToLower())
                {
                    count++;
                }
            }
            if (count < 1 || OutlineTextBox.Text == "")
            {
                MessageBox.Show("Данное начертание не определено для выбранного шрифта.\nВыберите начертание из списка.", "Шрифт", MessageBoxButtons.OK, MessageBoxIcon.Question);
                OutlineFlag = false;
            }
            else
            {
                OutlineFlag = true;
            }
        }

        private void FontError()
        {
            int count = 0;
            for (int i = 0; i < FontListBox.Items.Count; i++)
            {
                if (FontListBox.Items[i].ToString().ToLower() == FontTextBox.Text.ToLower())
                {
                    count++;
                }
            }
            if (count < 1 || FontTextBox.Text == "")
            {
                MessageBox.Show("Шрифт с указанным именем не существует.\nВыберите шрифт из списка.", "Шрифт", MessageBoxButtons.OK, MessageBoxIcon.Question);
                FontFlag = false;
            }
            else
            {
                FontFlag = true;
            }
        }

        private void ColorChange(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SampleLableToShow.ForeColor = colorDialog1.Color;
                FontColor = colorDialog1.Color;
            }
        }

        private void AbsSize()
        {
            value = int.Parse(SizeTextBox.Text.ToString());
            if (value < 0)
            {
                value = -value;
            }
        }
    }
}
