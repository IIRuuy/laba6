using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.Core.Token
{
    internal class Lexer
    {
        private List<TokenType> _lexemeList;

        public Lexer(List<TokenType> _lexemeList)
        {
            this._lexemeList = _lexemeList;
        }


        public TokenStream getTokenStream(string statement)
        {
            List<Token> tokens = new List<Token>();
            int position = 0;

            while (position < statement.Length)
                addToken(statement, ref position, tokens);

            //tokens.removeIf(token -> token.getType().equals(SPACE));

            return new TokenStream(tokens);
        }

        private void addToken(string statement, ref int position, List<Token> tokens) {
            foreach (TokenType type in _lexemeList)
            {
                string pattern = "^" + type.Regex;
                Match match = Regex.Match(statement.Substring(position), pattern);
                if (match.Success){
                        string value = match.Groups[0].Value;

                        Range range = new Range(position, position += value.Length);
                        tokens.Add(new Token(type, value, range));
                        return;
                }
             }
            
            throw new NotStatementException(position);
        }
    }
}
