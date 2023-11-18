using System.Diagnostics;

namespace content4all
{
    public partial class mainmenu : Form
    {
        int upfor1 = 114;
        int upfor2 = 87;
        bool but1click = false;
        bool but2click = false;
        bool but3click = false;
        bool but4click = false;

        public mainmenu(string kullaniciadi)
        {
            InitializeComponent();
            panel1.AutoScroll = false;
            VScrollProperties verticalScroll = panel1.VerticalScroll;
            verticalScroll.Enabled = true;
            verticalScroll.Visible = true;
            verticalScroll.Maximum = 100;
            panel1.AutoScroll = true;
            label1.Text = upfor1 + " UPs";
            label2.Text = upfor2 + " UPs";
            label5.Text = kullaniciadi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (but1click == false && but2click == false)
            {
                upfor1 += 1;
                but1click = true;
            }
            else if (but1click == false && but2click == true)
            {
                upfor1 += 2;
                but1click = true;
                but2click = false;
            }
            label1.Text = upfor1 + " UPs";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (but3click == false && but4click == false)
            {
                upfor2 += 1;
                but3click = true;
            }
            else if (but3click == false && but4click == true)
            {
                upfor2 += 2;
                but3click = true;
                but4click = false;
            }
            label2.Text = upfor2 + " UPs";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (but2click == false && but1click == false)
            {
                upfor1 -= 1;
                but2click = true;
            }
            else if (but2click == false && but1click == true)
            {
                upfor1 -= 2;
                but2click = true;
                but1click = false;
            }
            label1.Text = upfor1 + " UPs";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (but4click == false && but3click == false)
            {
                upfor2 -= 1;
                but4click = true;
            }
            else if (but4click == false && but3click == true)
            {
                upfor2 -= 2;
                but3click = false;
                but4click = true;
            }
            label2.Text = upfor2 + " UPs";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process p = new();
            ProcessStartInfo psi = new();
            psi.FileName = "TOU.html";
            psi.UseShellExecute = true;
            psi.Verb = "open";
            p.StartInfo = psi;
            p.Start();
        }
    }
}
