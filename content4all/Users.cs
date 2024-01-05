namespace content4all
{
    public class User
    {
        private string username;
        private string password;
        //private bool loggedIn;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
