using System.Text.RegularExpressions;

namespace WindowsFormsApp1.Core.Parser
{
    public static class Requirer
    {
        public static bool isDigit(string digit)
        {
            Match match = Regex.Match(digit, "\\d");
            return match.Success;
        }

        public static bool isLetter(string letter)
        {
            Match match = Regex.Match(letter, "[a-zA-Zа-яА-Я]");
            return match.Success;
        }

        public static bool isDash(string dash)
        {
            Match match = Regex.Match(dash, "-");
            return match.Success;
        }
    }
}
