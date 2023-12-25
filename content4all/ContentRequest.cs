namespace content4all
{
    public partial class ContentRequest : Form
    {
        public ContentRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                Contents.CRequests request = new Contents.CRequests(mainmenu.kullaniciadi, textBox1.Text, textBox2.Text, radioButton1.Checked, textBox3.Text);
                comboBox1.Items.Clear();
                foreach (var item in Contents.CRequests.requests)
                {
                    comboBox1.Items.Add(item.Subject);
                }
                MessageBox.Show("Your request has been created successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }
        public void GetRequest()
        {
            string req = comboBox1.SelectedItem.ToString();
            foreach (var request in Contents.CRequests.requests)
            {
                if (request.Subject == req)
                {
                    richTextBox1.Text = "Subject:  " + request.Subject + "\n\nRequester:  " + request.Requester + "\n\nStyle:  " + request.Style + "\n\nAI Generated:  " + request.Ai + "\n\nNotes:  " + request.Notes;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRequest();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in Contents.CRequests.requests)
            {
                comboBox1.Items.Add(item.Subject);
            }
        }

        private void ContentRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainmenu.CRequestFormOpen = false;
        }
    }
}