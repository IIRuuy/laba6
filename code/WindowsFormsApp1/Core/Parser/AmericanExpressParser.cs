namespace WindowsFormsApp1.Core.Parser
{
    internal class AmericanExpressParser
    {
        public bool parse(string statement, int startPos = 0)
        {
            if (statement.Length - startPos < 15)
                return false;

            for(int i = 0; i< 15; i++)
            {
                if (!checkOnDigit(statement[startPos+i]))
                    return parse(statement, startPos + 1);
            }

            return true;
        }
        private bool checkOnDigit(char str)
        {
            return Requirer.isDigit(str.ToString());
        }
    }
}
