namespace WindowsFormsApp1.Core.Parser
{
    internal class MacAdressParser
    {
        public bool parse(string statement, int startPos = 0)
        {
            if (statement.Length - startPos < 17)
                return false;

            if (!checkOnLetterOrDigit(statement[startPos]))
                return parse(statement, startPos + 1);
            if (!checkOnLetterOrDigit(statement[startPos+1]))
                return parse(statement, startPos + 1);
            if (!checkOnDash(statement[startPos + 2]))
                return parse(statement, startPos + 1);

            if (!checkOnLetterOrDigit(statement[startPos+3]))
                return parse(statement, startPos + 1);
            if (!checkOnLetterOrDigit(statement[startPos + 4]))
                return parse(statement, startPos + 1);
            if (!checkOnDash(statement[startPos + 5]))
                return parse(statement, startPos + 1);

            if (!checkOnLetterOrDigit(statement[startPos + 6]))
                return parse(statement, startPos + 1);
            if (!checkOnLetterOrDigit(statement[startPos + 7]))
                return parse(statement, startPos + 1);
            if (!checkOnDash(statement[startPos + 8]))
                return parse(statement, startPos + 1);

            if (!checkOnLetterOrDigit(statement[startPos + 9]))
                return parse(statement, startPos + 1);
            if (!checkOnLetterOrDigit(statement[startPos + 10]))
                return parse(statement, startPos + 1);
            if (!checkOnDash(statement[startPos + 11]))
                return parse(statement, startPos + 1);

            if (!checkOnLetterOrDigit(statement[startPos + 12]))
                return parse(statement, startPos + 1);
            if (!checkOnLetterOrDigit(statement[startPos + 13]))
                return parse(statement, startPos + 1);
            if (!checkOnDash(statement[startPos + 14]))
                return parse(statement, startPos + 1);


            if (!checkOnLetterOrDigit(statement[startPos + 15]))
                return parse(statement, startPos + 1);
            if (!checkOnLetterOrDigit(statement[startPos + 16]))
                return parse(statement, startPos + 1);

            return true;
        }


        private bool checkOnLetterOrDigit(char str)
        {
            return Requirer.isLetter(str.ToString()) | Requirer.isDigit(str.ToString());
        }
        private bool checkOnDash(char str)
        {
            return Requirer.isDash(str.ToString());
        }
    }
}
