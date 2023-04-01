using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.dto
{
    public class Order
    {
        private int id;
        private Reader reader;
        private List<Book> books;
        private string date;
        private string bookReturnDate;

        public Order() { }

        public int Id { get => id; set => id = value; }
        public Reader Reader { get => reader; set => reader = value; }
        public List<Book> Books { get => books; set => books = value; }
        public string Date { get => date; set => date = value; }
        public string BookReturnDate { get => bookReturnDate; set => bookReturnDate = value; }
    }
}
