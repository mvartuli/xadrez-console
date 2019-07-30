using System;

namespace Ntabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) 
            : base(msg)
        {
        }
    }
}
