using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.dto
{
    public class Author
    {
        private int id;
        private string fullName;

        public Author() { }

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
    }
}
