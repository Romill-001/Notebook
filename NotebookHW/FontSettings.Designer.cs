namespace NotebookHW
{
    partial class FontSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.OutlineLabel = new System.Windows.Forms.Label();
            this.FontLabel = new System.Windows.Forms.Label();
            this.SampleLableToShow = new System.Windows.Forms.Label();
            this.SampleGB = new System.Windows.Forms.GroupBox();
            this.FontListBox = new System.Windows.Forms.ListBox();
            this.OutlineListBox = new System.Windows.Forms.ListBox();
            this.SizeListBox = new System.Windows.Forms.ListBox();
            this.FontTextBox = new System.Windows.Forms.TextBox();
            this.OutlineTextBox = new System.Windows.Forms.TextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorChangeButton = new System.Windows.Forms.Button();
            this.SampleGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(282, 327);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.CancelClick);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(197, 327);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OkClick);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel.Location = new System.Drawing.Point(279, 9);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(54, 15);
            this.SizeLabel.TabIndex = 3;
            this.SizeLabel.Text = "Размер:";
            // 
            // OutlineLabel
            // 
            this.OutlineLabel.AutoSize = true;
            this.OutlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutlineLabel.Location = new System.Drawing.Point(149, 9);
            this.OutlineLabel.Name = "OutlineLabel";
            this.OutlineLabel.Size = new System.Drawing.Size(81, 15);
            this.OutlineLabel.TabIndex = 5;
            this.OutlineLabel.Text = "Начертание:";
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontLabel.Location = new System.Drawing.Point(12, 9);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(53, 15);
            this.FontLabel.TabIndex = 7;
            this.FontLabel.Text = "Шрифт:";
            // 
            // SampleLableToShow
            // 
            this.SampleLableToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SampleLableToShow.Location = new System.Drawing.Point(3, 16);
            this.SampleLableToShow.Name = "SampleLableToShow";
            this.SampleLableToShow.Size = new System.Drawing.Size(196, 88);
            this.SampleLableToShow.TabIndex = 9;
            this.SampleLableToShow.Text = "AaBbYyZz";
            this.SampleLableToShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SampleGB
            // 
            this.SampleGB.Controls.Add(this.SampleLableToShow);
            this.SampleGB.Location = new System.Drawing.Point(155, 195);
            this.SampleGB.Name = "SampleGB";
            this.SampleGB.Size = new System.Drawing.Size(205, 107);
            this.SampleGB.TabIndex = 10;
            this.SampleGB.TabStop = false;
            this.SampleGB.Text = "Образец:";
            // 
            // FontListBox
            // 
            this.FontListBox.FormattingEnabled = true;
            this.FontListBox.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Times New Roman",
            "Cambria",
            "Comic Sans MS",
            "Consolas",
            "Georgia",
            "Segoe UI"});
            this.FontListBox.Location = new System.Drawing.Point(12, 53);
            this.FontListBox.Name = "FontListBox";
            this.FontListBox.Size = new System.Drawing.Size(120, 95);
            this.FontListBox.TabIndex = 11;
            this.FontListBox.SelectedValueChanged += new System.EventHandler(this.FontValueChange);
            // 
            // OutlineListBox
            // 
            this.OutlineListBox.FormattingEnabled = true;
            this.OutlineListBox.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "полужирный",
            "подчёркнутый текст"});
            this.OutlineListBox.Location = new System.Drawing.Point(152, 56);
            this.OutlineListBox.Name = "OutlineListBox";
            this.OutlineListBox.Size = new System.Drawing.Size(120, 56);
            this.OutlineListBox.TabIndex = 12;
            this.OutlineListBox.SelectedValueChanged += new System.EventHandler(this.OutlineValueChange);
            // 
            // SizeListBox
            // 
            this.SizeListBox.FormattingEnabled = true;
            this.SizeListBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.SizeListBox.Location = new System.Drawing.Point(282, 53);
            this.SizeListBox.Name = "SizeListBox";
            this.SizeListBox.Size = new System.Drawing.Size(75, 95);
            this.SizeListBox.TabIndex = 13;
            this.SizeListBox.SelectedValueChanged += new System.EventHandler(this.SizeValueChange);
            // 
            // FontTextBox
            // 
            this.FontTextBox.Location = new System.Drawing.Point(12, 27);
            this.FontTextBox.Name = "FontTextBox";
            this.FontTextBox.Size = new System.Drawing.Size(120, 20);
            this.FontTextBox.TabIndex = 14;
            this.FontTextBox.TextChanged += new System.EventHandler(this.FontChange2);
            // 
            // OutlineTextBox
            // 
            this.OutlineTextBox.Location = new System.Drawing.Point(152, 27);
            this.OutlineTextBox.Name = "OutlineTextBox";
            this.OutlineTextBox.Size = new System.Drawing.Size(120, 20);
            this.OutlineTextBox.TabIndex = 15;
            this.OutlineTextBox.TextChanged += new System.EventHandler(this.OutlineChange2);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(282, 27);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(75, 20);
            this.SizeTextBox.TabIndex = 16;
            this.SizeTextBox.TextChanged += new System.EventHandler(this.FontSIzeChange2);
            // 
            // ColorChangeButton
            // 
            this.ColorChangeButton.Location = new System.Drawing.Point(12, 327);
            this.ColorChangeButton.Name = "ColorChangeButton";
            this.ColorChangeButton.Size = new System.Drawing.Size(120, 23);
            this.ColorChangeButton.TabIndex = 20;
            this.ColorChangeButton.Text = "Изменить цвет";
            this.ColorChangeButton.UseVisualStyleBackColor = true;
            this.ColorChangeButton.Click += new System.EventHandler(this.ColorChange);
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 365);
            this.Controls.Add(this.ColorChangeButton);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.OutlineTextBox);
            this.Controls.Add(this.FontTextBox);
            this.Controls.Add(this.SizeListBox);
            this.Controls.Add(this.OutlineListBox);
            this.Controls.Add(this.FontListBox);
            this.Controls.Add(this.SampleGB);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.OutlineLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.cancel_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Шрифт";
            this.SampleGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label OutlineLabel;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Label SampleLableToShow;
        private System.Windows.Forms.GroupBox SampleGB;
        private System.Windows.Forms.ListBox FontListBox;
        private System.Windows.Forms.ListBox OutlineListBox;
        private System.Windows.Forms.ListBox SizeListBox;
        private System.Windows.Forms.TextBox FontTextBox;
        private System.Windows.Forms.TextBox OutlineTextBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorChangeButton;
    }
}