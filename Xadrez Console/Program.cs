using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tab = new Tabuleiros(8, 8);

            Telas.imprimirTabuleiro(tab);
            

            Console.WriteLine("");
        }
    }
}
