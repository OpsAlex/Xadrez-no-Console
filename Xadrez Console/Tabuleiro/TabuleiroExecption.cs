using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.Tabuleiro
{
    class TabuleiroExecption : Exception
    {
        public TabuleiroExecption(string msg) : base(msg)
        {

        }
    }
}
