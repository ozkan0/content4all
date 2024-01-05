using System.Diagnostics;

namespace content4all
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }
        public static Dictionary<string, User> Users = new Dictionary<string, User>();
        Members members = new();

        private void LoginRegister_Load(object sender, EventArgs e)
        {
            //pre-set users to test Members form, not required to delete
            User unfeagle = new User("unfaithfuleagle", "usa10033");
            User hans = new User("hans2", "creature54");
            User dono = new User("dono", "123321");
            Users.Add("unfaithfuleagle", unfeagle);
            Users.Add("hans2", hans);
            Users.Add("dono", dono);
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
                if (Users.ContainsKey(textBox1.Text))
                {
                    StatusRed();
                    toolStripStatusLabel1.Text = "Username already exists.";
                }
                else if (textBox2.Text == textBox3.Text && textBox2.Text != "")
                {
                    User user = new User(textBox1.Text, textBox2.Text);
                    Users.Add(textBox1.Text, user);
                    StatusGreen(); toolStripStatusLabel1.Text = "Registration successful.";
                    radioButton1.Checked = true;
                    textBox2.Clear(); textBox3.Clear();
                }
                else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    StatusRed();
                    toolStripStatusLabel1.Text = "Please fill all the fields.";
                }
                else
                {
                    StatusRed();
                    toolStripStatusLabel1.Text = "Passwords do not match.";

                }
            }
            else if (radioButton1.Checked)
            {

                if (Users.ContainsKey(textBox1.Text))
                {
                    if (Users[textBox1.Text].Password == textBox2.Text)
                    {
                        StatusGreen();
                        toolStripStatusLabel1.Text = "Login successful.";
                        members.SetMembers(Users);
                        //mainmenu main = new();
                        mainmenu.kullaniciadi = textBox1.Text;
                        //main.ShowDialog();
                        this.Hide();
                        var main = new mainmenu();
                        main.Closed += (s, args) => this.Close();
                        main.Show();
                    }
                    else
                    {
                        StatusRed();
                        toolStripStatusLabel1.Text = "Wrong password.";
                    }
                }
                else
                {
                    StatusRed();
                    toolStripStatusLabel1.Text = "Username does not exist.";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process pp = new();
            ProcessStartInfo psi = new();
            psi.FileName = "PP.html";
            psi.UseShellExecute = true;
            psi.Verb = "open";
            pp.StartInfo = psi;
            pp.Start();

        }
    }
}