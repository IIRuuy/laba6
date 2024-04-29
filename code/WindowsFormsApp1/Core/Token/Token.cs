namespace WindowsFormsApp1.Core.Token
{
    public class Token
    {
        public TokenType TokenType { get; set; }
        public string Value {  get; set; }
        public Range Range { get; set; }
        // public int Position { get; set; }
        public Token(TokenType TokenType, string Value, Range range) { 
            this.TokenType = TokenType;
            this.Value = Value;
            this.Range = range;
        }
        public override string ToString()
        {
            return "Token(Value=\""+Value+"\", Position=(" + Range.Start + "-" + Range.End + "), TokenType=" + TokenType.Type.ToString() + ")\r\n";
        }
    }
}
