using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Exceptions
{
    internal class CartItemCannotBeNullException : Exception
    {
        public CartItemCannotBeNullException()
        {

        }

        public CartItemCannotBeNullException(string message)
            : base(message)
        {

        }
    }
}
