using Bookful.domain.constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.exception
{
    public class CommonException : Exception
    {
        private readonly Code code;
        private readonly string message;

        public CommonException()
        {
        }

        public CommonException(Code code, string message)
        {
            this.code = code;
            this.message = message;
        }

        public Code Code => code;

        public string UserMessage => message;
    }
}
