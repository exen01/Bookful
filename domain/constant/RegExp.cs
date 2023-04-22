using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.constant
{
    public class RegExp
    {
        public static readonly string login = "^[a-zA-Z0-9а-яА-Я. _-]{4,15}$";
        public static readonly string password = "^[a-zA-Z0-9а-яА-Я.,:; _?!+=/'\\\\\"*(){}\\[\\]\\-]{8,100}$";
    }
}
