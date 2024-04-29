using System;

namespace WindowsFormsApp1.Core.Token
{
    internal class NotStatementException : Exception
    {
        public NotStatementException(int startPostion)
            : base("Неопознанный токен на позиции: " + startPostion) {}
    }
}
