﻿using System;
using System.Collections.Generic;

namespace ITI.CIL_Cowding
{
    public class PreExecutionContext : IPreExecutionContext
    {
        CILTypeManager _typeManager;
        List<IValue> _localsVar;

        /// <summary>
        /// Get or Set locals variables in the current context.
        /// </summary>
        public List<IValue> LocalsVar
        {
            get {return _localsVar;}

            set {
                        _localsVar = value;   
                }
        }


        public CILTypeManager TypeManager
        {
            get { return _typeManager; }
        }
        public PreExecutionContext()
        {
            _typeManager = new CILTypeManager();
            _localsVar = new List<IValue>();


        }

        /// <summary>
        /// Create all functions from functionNode.
        /// </summary>
        /// <param name="code">All the source code, therefore the list of function node.</param>
        /// <returns>List of functions ready to execute.</returns>
        public List<Function> PreExecut (List<FunctionNode> code)
        {
            List<Function> myFunctions = new List<Function>();

            foreach(FunctionNode function in code) 
            {
                myFunctions.Add( function.PreExecute(this) );
            }

            return myFunctions;
        }


    }
}
