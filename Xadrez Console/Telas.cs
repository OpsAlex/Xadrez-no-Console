using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console
{
    class Telas
    {
        public static void imprimirTabuleiro(Tabuleiros tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    Console.Write(tab.peca(i,j) + "");
                }
                Console.WriteLine();
            }

        }
    }
}
