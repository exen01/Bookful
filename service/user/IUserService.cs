using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.service.user
{
    public interface IUserService
    {
        void Registration(string login, string password);
    }
}
