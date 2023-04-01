using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.dto
{
    public class Reader
    {
        private int id;
        private string name;
        private string surname;
        private int libraryCardNumber;
        private string address;
        private string phoneNumber;

        public Reader() { }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int LibraryCardNumber { get => libraryCardNumber; set => libraryCardNumber = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
