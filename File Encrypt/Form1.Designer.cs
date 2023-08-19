namespace File_Encrypt
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
            btnSelect = new Label();
            label2 = new Label();
            btnEncrypt = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnDecrypt = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.AutoSize = true;
            btnSelect.BackColor = Color.DodgerBlue;
            btnSelect.ForeColor = SystemColors.ButtonHighlight;
            btnSelect.Location = new Point(22, 42);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(89, 25);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select File";
            btnSelect.Click += btnSelect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 42);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // btnEncrypt
            // 
            btnEncrypt.AutoSize = true;
            btnEncrypt.BackColor = Color.DodgerBlue;
            btnEncrypt.ForeColor = SystemColors.ButtonHighlight;
            btnEncrypt.Location = new Point(22, 285);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(148, 25);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "Encrypt and Save";
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(22, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 75);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Save Options";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(138, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(97, 29);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Replace";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(8, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(127, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Create New";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            btnDecrypt.AutoSize = true;
            btnDecrypt.BackColor = Color.DodgerBlue;
            btnDecrypt.ForeColor = SystemColors.ButtonHighlight;
            btnDecrypt.Location = new Point(374, 285);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(151, 25);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt and Save";
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 213);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(503, 31);
            textBox1.TabIndex = 5;
            textBox1.TabStop = false;
            textBox1.UseSystemPasswordChar = true;
            textBox1.MouseEnter += textBox1_MouseEnter;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnDecrypt);
            Controls.Add(groupBox1);
            Controls.Add(btnEncrypt);
            Controls.Add(label2);
            Controls.Add(btnSelect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnSelect;
        private Label label2;
        private Label btnEncrypt;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label btnDecrypt;
        private TextBox textBox1;
    }
}