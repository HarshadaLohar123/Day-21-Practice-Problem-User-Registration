using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationException
{
    public class ExceptionalHandling : Exception
    {
        public enum ExceptionType
        {
            NULL_FIELD,
            INVALID_INPUT,
        }
        private readonly ExceptionType type;
        public ExceptionalHandling(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
