﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class IncorrectInputHandling : Exception
    {
        public IncorrectInputHandling(string message) : base(message) { }
    }
}
