using Bookful.domain.dto;

namespace Bookful.dao.user
{
    public interface IUserDao
    {
        /// <summary>
        /// Проверка существующего логина
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <returns>true если логин существует, иначе false</returns>
        bool IsExistsLogin(string login);

        /// <summary>
        /// Вставка данных пользователя в базу данных
        /// </summary>
        /// <param name="user">Объект данных пользователя</param>
        void InsertNewUser(User user);
    }
}
