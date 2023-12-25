using Contents;
using System.Diagnostics;
using System.Drawing;

namespace content4all
{
    public partial class mainmenu : Form
    {
        public static bool MembersFormOpen = false;
        public static bool CRequestFormOpen = false;
        public static string kullaniciadi { get; set; }
        ContentDictionary contentDictionary = new ContentDictionary();
        public mainmenu()
        {
            InitializeComponent();
            label5.Text = kullaniciadi;
            Content content1 = new Content(0, "Astronaut", "BingAI", 114);
            Content content2 = new Content(1, "Sky at midnight", "BingAI", 87);
            contentDictionary.AddContent(content1);
            contentDictionary.AddContent(content2);
        }
        public int ChangeUps(int Id, int change)
        {
            int up = ContentDictionary.contents[Id].Ups;
            int latestup = up + change;
            return latestup;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            label1.Text = ChangeUps(0, 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = true;
            label2.Text = ChangeUps(1, 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            label1.Text = ChangeUps(0, -1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button3.Enabled = true;
            label2.Text = ChangeUps(1, -1).ToString();
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
        private void button5_Click(object sender, EventArgs e)
        {
            if(CRequestFormOpen == true)
            {
                MessageBox.Show("Content Request form is already open.", "Info");
                return;
            }
            else
            {
                ContentRequest contentRequest = new();
                CRequestFormOpen = true;
                contentRequest.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MembersFormOpen == true)
            {
                MessageBox.Show("Members form is already open.","Info");
                return;
            }
            else
            {
                Members members = new();
                MembersFormOpen = true;
                members.Show();
            }
        }
    }
}
