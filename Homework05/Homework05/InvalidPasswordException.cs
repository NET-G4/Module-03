﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    internal class InvalidPasswordException:ArgumentException
    {
        public InvalidPasswordException(string MessageToUser)
            : base(MessageToUser)
        {

        }

    }
}