namespace Bookful.domain.dto
{
    public class Reader
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LibraryCardNumber { get; set; }
        public int ReadingRoomId { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public string DisplayFullNameCardNumber => $"{FirstName} {LastName} - {LibraryCardNumber}";
    }
}
