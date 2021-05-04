﻿using sly.i18n;
using sly.parser;

namespace sly.lexer
{
    public class LexicalError : ParseError
    {
        public LexicalError(int line, int column, char unexpectedChar, string i18n)
        {
            Line = line;
            Column = column;
            UnexpectedChar = unexpectedChar;
            ErrorType = ErrorType.UnexpectedChar;
            I18n = i18n;
        }

        private string I18n;
        
        public char UnexpectedChar { get; set; }

        public override string ErrorMessage => I18N.Instance.GetText(I18n,Message.UnexpectedChar,UnexpectedChar.ToString());

        public override string ToString()
        {
            return ErrorMessage;
        }
    }
}