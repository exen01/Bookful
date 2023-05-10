namespace Bookful.domain.constant
{
    public class RegExp
    {
        public static readonly string login = "^[a-zA-Z0-9а-яА-Я. _-]{4,15}$";
        public static readonly string password = "^[a-zA-Z0-9а-яА-Я.,:; _?!+=/'\\\\\"*(){}\\[\\]\\-]{8,100}$";
        public static readonly string bookTitle = "^[a-zA-Zа-яА-Я0-9,.!?;:'\"\\s-]{1,50}$";
        public static readonly string bookAuthor = "^[a-zA-Zа-яА-Я\\s.'-]{1,100}$";
        public static readonly string bookPublicationHouse = "^[\\w\\s\\-\\.,!?\\(\\)]{1,100}$";
        public static readonly string readerFirstName = "^[a-zA-Zа-яА-Я\\s-]{1,50}$";
        public static readonly string readerLastName = "^[a-zA-Zа-яА-ЯёЁ]+\\s?[a-zA-Zа-яА-ЯёЁ]*\\-?[a-zA-Zа-яА-ЯёЁ]*$";
        public static readonly string readingRoomSpecialization = "^[a-zA-Zа-яА-Я0-9,.!?(){}|\\/\\s-]{1,100}$";
    }
}
