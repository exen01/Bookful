namespace Bookful.domain.dto
{
    public class User
    {
        private long id;
        private string login;
        private string password;

        public User() { }

        public long Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }
}
