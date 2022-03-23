using System;
using System.Collections.Generic;
using System.Text;

namespace Linkscript
{
    public enum Token
    {
        Unknown,

        //Keywords
        Print,
        String,

        Identifier,
        Operator,
        Integer,
        IntLiteral,
        StrLiteral,


        //Punctuators
        LeftParenthesis,
        RightParenthesis,
        Semicolon,
    }
}