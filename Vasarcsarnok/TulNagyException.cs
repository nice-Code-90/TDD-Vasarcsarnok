using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasarcsarnokApp
{
    public class TulNagyException : Exception
    {
        public TulNagyException(string message) : base(message)
        {
        }
    }
}