namespace Bookful.domain.dto
{
    public class User
    {
        private long id;
        private string login;
        private string password;

        public User()
        {
        }

        public User(long id, string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
        }

        public long Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }
}
