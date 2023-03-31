using Bookful.domain.constant;
using Bookful.domain.exception;
using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;

namespace Bookful.util
{
    public class ValidationUtils
    {
        public static bool ValidateLogin(string login)
        {
            var result = Regex.Match(login, RegExp.login);
            if (result.Success)
            {
                return true;
            }
            else
            {
                throw new CommonException(Code.WRONG_LOGIN, "Некорректный login");
            }

        }

        public static bool ValidatePassword(string password)
        {
            var result = Regex.Match(password, RegExp.login);
            if (result.Success)
            {
                return true;
            }
            else
            {
                throw new CommonException(Code.WRONG_PASSWORD, "Некорректный password");
            }
        }
    }
}
