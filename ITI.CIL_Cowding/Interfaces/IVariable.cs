﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    public interface IVariable
    {
        string Label
        {
            get;
        }
        Value Value
        {
            get;
        }
    }
}