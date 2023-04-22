using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.dto
{
    public class ReadingRoom
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Specialization { get; set; }
        public int SeatsCount { get; set; }
    }
}
