using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class OutOfIdException : Exception
    {
        public OutOfIdException(string message) : base(message) { }
    }
}
