namespace content4all
{
    public partial class Members : Form
    {
        private Dictionary<string, string> memberList;
        public Members(Dictionary<string, string> memberList)
        {
            InitializeComponent();
            this.memberList = memberList;
        }

        private void Members_Load(object sender, EventArgs e)
        {
            foreach (var pair in memberList)
            {
                listBox1.Items.Add(pair.Key);
            }

        }

    }
}
