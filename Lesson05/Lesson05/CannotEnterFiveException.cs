﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal class CannotEnterFiveException : IncorrectIputException
    {
        public CannotEnterFiveException(string message)
            : base(message)
        { }

    }
}
