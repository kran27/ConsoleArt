using AltUI.Controls;

namespace ConsoleArt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            richTextBox1 = new DarkRichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            darkButton1 = new DarkButton();
            label1 = new DarkLabel();
            numericUpDown1 = new DarkNumericUpDown();
            button1 = new DarkButton();
            label2 = new DarkLabel();
            numericUpDown2 = new DarkNumericUpDown();
            checkBox1 = new DarkCheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 3);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 415);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(26, 26, 28);
            richTextBox1.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(richTextBox1, 4);
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.ForeColor = Color.FromArgb(213, 213, 213);
            richTextBox1.Location = new Point(352, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(445, 415);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.00264F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9973564F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(darkButton1, 6, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(richTextBox1, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 5, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 3, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // darkButton1
            // 
            darkButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            darkButton1.BorderColour = Color.Empty;
            darkButton1.CustomColour = false;
            darkButton1.FlatBottom = false;
            darkButton1.FlatTop = false;
            darkButton1.Location = new Point(737, 424);
            darkButton1.Name = "darkButton1";
            darkButton1.Padding = new Padding(5);
            darkButton1.Size = new Size(60, 23);
            darkButton1.TabIndex = 6;
            darkButton1.Text = "Preview";
            darkButton1.Click += darkButton1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(3, 428);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Max Width";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(74, 424);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(197, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BorderColour = Color.Empty;
            button1.CustomColour = false;
            button1.FlatBottom = false;
            button1.FlatTop = false;
            button1.Location = new Point(635, 424);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(95, 23);
            button1.TabIndex = 5;
            button1.Text = "Process Again";
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(277, 428);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Max Height";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Dock = DockStyle.Fill;
            numericUpDown2.Location = new Point(352, 424);
            numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(196, 23);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(554, 426);
            checkBox1.Name = "checkBox1";
            checkBox1.Offset = 1;
            checkBox1.Size = new Size(75, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Dithering";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            CornerStyle = CornerPreference.Default;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(31, 31, 32);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DarkRichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DarkLabel label1;
        private DarkNumericUpDown numericUpDown1;
        private DarkButton button1;
        private DarkLabel label2;
        private DarkNumericUpDown numericUpDown2;
        private DarkCheckBox checkBox1;
        private DarkButton darkButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}