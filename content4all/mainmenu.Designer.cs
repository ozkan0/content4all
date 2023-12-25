namespace content4all
{
    partial class mainmenu
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button4 = new Button();
            label2 = new Label();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            button5 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.astro;
            pictureBox1.Location = new Point(23, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("High Tower Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 451);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "content4all - Home";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Teal;
            linkLabel2.Location = new Point(274, 2);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(85, 13);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Online Members";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(4, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 423);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(69, 2);
            label4.Name = "label4";
            label4.Size = new Size(153, 18);
            label4.TabIndex = 9;
            label4.Text = "\"Astronaut\" by BingAI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(69, 320);
            label3.Name = "label3";
            label3.Size = new Size(191, 18);
            label3.TabIndex = 8;
            label3.Text = "\"Sky at midnight\" by BingAI";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = Properties.Resources.down;
            button4.Location = new Point(299, 511);
            button4.Name = "button4";
            button4.Size = new Size(25, 25);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(299, 471);
            label2.Name = "label2";
            label2.Size = new Size(22, 17);
            label2.TabIndex = 7;
            label2.Text = "87";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = Properties.Resources.up;
            button3.Location = new Point(299, 423);
            button3.Name = "button3";
            button3.Size = new Size(25, 25);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.skyam;
            pictureBox2.Location = new Point(23, 341);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(270, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.down;
            button2.Location = new Point(299, 195);
            button2.Name = "button2";
            button2.Size = new Size(25, 25);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(299, 155);
            label1.Name = "label1";
            label1.Size = new Size(29, 17);
            label1.TabIndex = 3;
            label1.Text = "114";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.up;
            button1.Location = new Point(299, 107);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(335, 459);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(27, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "TOS";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 460);
            label5.Name = "label5";
            label5.Size = new Size(64, 14);
            label5.TabIndex = 6;
            label5.Text = "username";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(201, 455);
            button5.Name = "button5";
            button5.Size = new Size(126, 23);
            button5.TabIndex = 8;
            button5.Text = "Request a Content 📩";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.online12;
            pictureBox3.Location = new Point(9, 461);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(12, 12);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // mainmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(374, 480);
            Controls.Add(pictureBox3);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Name = "mainmenu";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button4;
        private Label label2;
        private Button button3;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label5;
        private Button button5;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel2;
    }
}