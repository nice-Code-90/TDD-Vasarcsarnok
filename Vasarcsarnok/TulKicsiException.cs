using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasarcsarnokApp
{
    public class TulKicsiException : Exception
    {
        public TulKicsiException(string message) : base(message)
        {
        }
    }
}