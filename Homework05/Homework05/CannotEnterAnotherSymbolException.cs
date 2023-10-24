using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    internal class CannotEnterAnotherSymbolException : Exception
    {
        public CannotEnterAnotherSymbolException(string str)
            : base (str)
        {

        }
    }
}
