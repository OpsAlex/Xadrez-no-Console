using System;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiros tab = new Tabuleiros(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                Telas.imprimirTabuleiro(tab);
            }
            catch (TabuleiroExecption e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("");
        }
    }
}
