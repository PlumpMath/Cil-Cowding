﻿using System;
using System.Collections.Generic;

namespace ITI.CIL_Cowding
{
    public class FunctionNode : Node
    {
        string _namefct;
        string _returnType;
        List<string> _parameters;
        List<InstructionNode> _code;

        public string Name
        {
            get { return _namefct; }
        }
        public FunctionNode(string name, string returnType, List<InstructionNode> code, List<string> parameters)
        {
            _namefct = name;
            _returnType = returnType;
            _code = code;
            _parameters = new List<string>();

            foreach(string variable in parameters) 
            {
                _parameters.Add(variable);
            }
        }
        public Function PreExecute(PreExecutionContext pec)
        {
            ICILType returnType;
            List<ICILType> parameters = new List<ICILType>();
            List<ICILType> locvar = new List<ICILType>();


            // Gestion du type de retour
            returnType = pec.TypeManager.Find(_returnType);

            // Gestion des types de paramètres
            foreach (string str in _parameters)
            {
                parameters.Add( pec.TypeManager.Find( str ) );
            }

            // Gestion des types des locvar
            if( _code[0] is LocalsInitNode ) 
            {
                _code[0].PreExecute(pec);
            }

            return new Function( _namefct, returnType, parameters, pec.LocalsVar,  _code );
        }

    }
}
















// La faute à Microsoft si les gens comprennent rien à l'informatique.





//La faute aux cassos si Apple se fait des couilles en poil de titanium.

// La faute à Aymeric si les commentaires sont complètement pourris ! ... Mais en même temps il a pas tord ...