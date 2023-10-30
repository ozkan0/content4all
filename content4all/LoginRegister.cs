using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace content4all
{
    public partial class LoginRegister : Form
    {
        private Dictionary<string, string> kullanicilar;
        public LoginRegister()
        {
            InitializeComponent();
            kullanicilar = new Dictionary<string, string>();
        }

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
            button4.Text = "Üyeler";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Username";
            label2.Text = "Password";
            label3.Text = "Password Again";
            radioButton1.Text = "Login";
            radioButton2.Text = "Register";
            button3.Text = "OK";
            button4.Text = "Members";
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

        private void button3_Click(object sender, EventArgs e)
        {
            mainmenu main = new mainmenu();
            if (radioButton2.Checked)
            {
                if (textBox2.Text == textBox3.Text && textBox2.Text != "")
                {
                    kullanicilar.Add(textBox1.Text,textBox2.Text);
                    toolStripStatusLabel1.ForeColor = Color.Green;
                    toolStripStatusLabel1.Text = "Kayýt baþarýlý.";
                    radioButton1.Checked = true;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text=="")
                {
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Lütfen boþ býrakmayýn.";
                }
                else
                {
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Þifreleri kontrol ediniz.";

                }
            }
            else if (radioButton1.Checked)
            {
                if (kullanicilar.ContainsKey(textBox1.Text) && kullanicilar[textBox1.Text] == textBox2.Text)
                {
                    this.Hide();
                    toolStripStatusLabel1.Text = "Giriþ baþarýlý.";
                    main.ShowDialog();
                    ///////////////////
                    Application.Exit();
                }
                else if (textBox1.Text=="" || textBox2.Text == "")
                {
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Lütfen boþ býrakmayýn.";
                }
                else
                {
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Giriþ bilgileri hatalý.";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Members members = new Members(kullanicilar);
            members.Show();
        }
    }
}