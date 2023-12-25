namespace content4all
{
    partial class Members
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(128, 255, 128);
            listBox1.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(5, 11);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 139);
            listBox1.TabIndex = 0;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 159);
            Controls.Add(listBox1);
            Name = "Members";
            Text = "Members";
            FormClosed += Members_FormClosed;
            Load += Members_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}