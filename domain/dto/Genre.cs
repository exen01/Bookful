using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.dto
{
    public class Genre
    {
        private int id;
        private string name;

        public Genre() { }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
