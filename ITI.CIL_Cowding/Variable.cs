﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    class Variable : IVariable
    {
        Value _value;
        string _label;

        public string Label
        {
            get { return _label; }
        }

        public Value Value
        {
            get { return _value; }
        }

        public Variable(Value value, string label)
        {
            _value = value;
            _label = label;
        }
    }
}
