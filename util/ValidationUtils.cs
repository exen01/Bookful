using Bookful.domain.constant;
using Bookful.domain.dto;
using Bookful.domain.exception;
using Bookful.service.reader;
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

        public static bool ValidateBookTitle(string title)
        {
            var result = Regex.Match(title, RegExp.bookTitle);
            if (result.Success)
            {
                return true;
            }
            else
            {
                throw new CommonException(Code.WRONG_BOOK_TITLE, "Некорректное название");
            }
        }

        public static bool ValidateBookAuthor(string author)
        {
            var result = Regex.Match(author, RegExp.bookAuthor);
            if (result.Success)
            {
                return true;
            }
            else
            {
                throw new CommonException(Code.WRONG_AUTHOR, "Некорректное имя автора");
            }
        }

        public static bool ValidateBookPublicationHouse(string publicationHouse)
        {
            var result = Regex.Match(publicationHouse, RegExp.bookPublicationHouse);
            if (result.Success)
            {
                return true;
            }
            else
            {
                throw new CommonException(Code.WRONG_PUBLICATION_HOUSE, "Некорректное название издательсва");
            }
        }

        public static bool ValidateFirstName(string firstName)
        {
            var result = Regex.Match(firstName, RegExp.readerFirstName);
            if (result.Success)
            {
                return true;
            }
            else
            {
                throw new CommonException(Code.WRONG_FIRST_NAME, "Некорректное имя читателя");
            }
        }

        public static bool ValidateLastName(string lastName)
        {
            var result = Regex.Match(lastName, RegExp.readerLastName);
            if (result.Success)
            {
                return true;
            }
            else
            {
                throw new CommonException(Code.WRONG_LAST_NAME, "Некорректная фамилия читателя");
            }
        }

        public static bool ValidateSpecialization(string specialization)
        {
            var result = Regex.Match(specialization, RegExp.readingRoomSpecialization);
            if (result.Success)
            {
                return true;
            }
            else
            {
                throw new CommonException(Code.WRONG_SPECIALIZATION, "Некорректное название специализации");
            }
        }
    }
}
