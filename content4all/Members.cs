namespace content4all
{
    public partial class Members : Form
    {
        private Dictionary<string, User> Users = LoginRegister.Users;
        public Members()
        {
            InitializeComponent();
        }
        public void SetMembers(Dictionary<string, User> Users)
        {
            this.Users = Users;
        }
        private void Members_Load(object sender, EventArgs e)
        {
            foreach (var pair in Users)
            {
                listBox1.Items.Add(pair.Key);
            }
        }

        private void Members_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainmenu.MembersFormOpen = false;
        }
    }
}
