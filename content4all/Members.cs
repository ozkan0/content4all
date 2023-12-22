namespace content4all
{
    public partial class Members : Form
    {
        private static Dictionary<string, string> memberList;
        public Members()
        {
            InitializeComponent();
            //this.memberList = memberList;
        }
        public void SetMembers(Dictionary<string, string> members) { memberList = members; }
        private void Members_Load(object sender, EventArgs e)
        {
            foreach (var pair in memberList)
            {
                listBox1.Items.Add(pair.Key);
            }

        }

    }
}
