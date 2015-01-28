﻿using System;

namespace ITI.CIL_Cowding
{
    /// <summary>
    /// Push 1 (of type int32) if value1 equals value2, else push 0.
    /// </summary>
    public class CeqNode : BinaryComparatorNode
    {
       
        public CeqNode(int line)
            : base( line )
        {
        }
        public override IValue Comparator( IValue value1, IValue value2 )
        {
            /*
            IValue result;
            if ( value1.Data.ToString() == value2.Data.ToString() )
            {
                result = new Value( value1.Type, 1 );
            }
            else
            {
                result = new Value( value1.Type, 0 );
            }
            return result;
             * */

            {
                IValue result;
                if (value1.Type.FullName == "System.Int32")
                {
                    if ((int)value1.Data == (int)value2.Data)
                    {
                        result = new Value(value1.Type, 1);
                    }
                    else
                    {
                        result = new Value(value1.Type, 0);
                    }
                }
                else if (value1.Type.FullName == "System.Double")
                {
                    if ((double)value1.Data == (double)value2.Data)
                    {
                        result = new Value(value1.Type, 1.0);
                    }
                    else
                    {
                        result = new Value(value1.Type, 0.0);
                    }
                }
                else
                {
                    result = new Value(value1.Type, 0);
                }

                return result;
            }
        }
    }
}