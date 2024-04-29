using System;
using System.Collections.Generic;
using System.Xml;

namespace WindowsFormsApp1.Core.Token
{
    internal class LexemeFactory
    {
        public List<TokenType> getLexems(string url)
        {
            List<TokenType> lexemes = new List<TokenType>();


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(url);

            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    TokenType tokenType = new TokenType();

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "type")
                            tokenType.Type = (TokenTypeEnum) Enum.Parse(typeof(TokenTypeEnum), childnode.InnerText);

                        if (childnode.Name == "regex")
                            tokenType.Regex = childnode.InnerText;

                    }
                    lexemes.Add(tokenType);
                }
            }

            return lexemes;
        }
    }
}
