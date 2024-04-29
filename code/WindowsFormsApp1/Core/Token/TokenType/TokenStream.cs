using System.Collections.Generic;

namespace WindowsFormsApp1.Core.Token
{
    public class TokenStream
    {
        private List<Token> Tokens { get; set; }
        private int CurrentIndex { get; set; }

        public TokenStream(List<Token> _tokens)
        {
            this.Tokens = _tokens;
            this.CurrentIndex = 0;
        }
        public bool hasNext() => CurrentIndex < Tokens.Count;
        public Token Next() => Tokens[CurrentIndex++];
    }
}
