using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiros tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
