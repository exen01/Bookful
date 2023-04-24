namespace Bookful.domain.dto
{
    public class IssuedBook
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly? ReturnDate { get; set; }
        public DateOnly ExpectedReturnDate { get; set; }
    }
}
