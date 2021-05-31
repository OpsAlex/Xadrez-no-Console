using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.Tabuleiro
{
    class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }
        public Tabuleiros tab { get; protected set; }

        public Peca ()
        {

        }

        public Peca(Posicao posicao, Cor cor, Tabuleiros tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }
    }
}
