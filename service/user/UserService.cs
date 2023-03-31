using Bookful.dao.user;
using Bookful.domain.constant;
using Bookful.domain.exception;

namespace Bookful.service.user
{
    public class UserService : IUserService
    {
        private readonly IUserDao userDao;

        public UserService()
        {
            this.userDao = new UserDaoImpl();
        }

        public void Registration(string login, string password)
        {
            if (userDao.IsExistsLogin(login))
            {
                throw new CommonException(Code.USER_ALREADY_EXISTS, "Этот логин уже занят, придумайте другой.");
            }

            string encryptPassword = password;
            userDao.InsertNewUser(new domain.dto.User() { Login = login, Password = encryptPassword });
        }
    }
}
