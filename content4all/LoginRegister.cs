using Contents;
using System.Security.Cryptography.X509Certificates;

namespace content4all
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }

        Dictionary<string, string> kullanicilar = new Dictionary<string, string>();
        Members members = new();

        private void LoginRegister_Load(object sender, EventArgs e)
        {
            kullanicilar.Add("unfaithfuleagle", "usa10033");
            kullanicilar.Add("hans2", "creature54");
            kullanicilar.Add("dono", "123321");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Kullanýcý adý";
            label2.Text = "Þifre";
            label3.Text = "Tekrar Þifre";
            radioButton1.Text = "Giriþ Yap";
            radioButton2.Text = "Kayýt Ol";
            button3.Text = "Tamam";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Username";
            label2.Text = "Password";
            label3.Text = "Password Again";
            radioButton1.Text = "Login";
            radioButton2.Text = "Register";
            button3.Text = "OK";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox3.Visible = true;
        }
        private void StatusRed() { toolStripStatusLabel1.ForeColor = Color.Red; }
        private void StatusGreen() { toolStripStatusLabel1.ForeColor = Color.Green; }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (textBox2.Text == textBox3.Text && textBox2.Text != "")
                {
                    kullanicilar.Add(textBox1.Text, textBox2.Text);
                    StatusGreen(); toolStripStatusLabel1.Text = "Kayýt baþarýlý.";
                    radioButton1.Checked = true;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    StatusRed();
                    toolStripStatusLabel1.Text = "Lütfen boþ býrakmayýn.";
                }
                else
                {
                    StatusRed();
                    toolStripStatusLabel1.Text = "Þifreleri kontrol ediniz.";

                }
            }
            else if (radioButton1.Checked)
            {
                if (kullanicilar.ContainsKey(textBox1.Text) && kullanicilar[textBox1.Text] == textBox2.Text)
                {
                    mainmenu.kullaniciadi = textBox1.Text;
                    this.Hide();
                    mainmenu main = new();
                    members.SetMembers(kullanicilar);
                    toolStripStatusLabel1.Text = "Giriþ baþarýlý.";
                    main.ShowDialog();

                    ///////////////////
                    Application.Exit();
                }
                else if (textBox1.Text == "" || textBox2.Text == "")
                {
                    StatusRed();
                    toolStripStatusLabel1.Text = "Lütfen boþ býrakmayýn.";
                }
                else
                {
                    StatusRed();
                    toolStripStatusLabel1.Text = "Giriþ bilgileri hatalý.";
                }
            }
        }

    }
}