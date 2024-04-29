namespace WindowsFormsApp1.Core.Token
{
    public class TokenType
    {
        public string Regex { get; set; }
        public TokenTypeEnum Type { get; set; }
        public TokenType(TokenTypeEnum Type, string Regex) {
            this.Regex = Regex;
            this.Type = Type;
        }
        public TokenType() {}

    }
}
