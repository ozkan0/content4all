namespace content4all
{
    partial class LoginRegister
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.tr__Custom_;
            button1.Location = new Point(0, 210);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.en__Custom_;
            button2.Location = new Point(31, 210);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(31, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(31, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(255, 255, 192);
            radioButton1.Location = new Point(43, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Giriş Yap";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(255, 224, 192);
            radioButton2.Location = new Point(150, 27);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kayıt Ol";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 61);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 105);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 7;
            label2.Text = "Şifre";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Location = new Point(31, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 8;
            textBox3.UseSystemPasswordChar = true;
            textBox3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 149);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "Tekrar Şifre";
            label3.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(109, 203);
            button3.Name = "button3";
            button3.Size = new Size(75, 36);
            button3.TabIndex = 10;
            button3.Text = "Tamam";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Location = new Point(202, 210);
            button4.Name = "button4";
            button4.Size = new Size(70, 23);
            button4.TabIndex = 11;
            button4.Text = "Üyeler";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 239);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(284, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(statusStrip1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "LoginRegister";
            Text = "Login/Register C4A";
            Load += LoginRegister_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button3;
        private Button button4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}