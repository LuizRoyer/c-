using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdMovimentos { get; private set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tab = tab;
            this.QtdMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();

        public void ExecutarMovimento()
        {
            QtdMovimentos++;
        }
        public void ReverterMovimento()
        {
            QtdMovimentos--;
        }
        public bool ValidarMovimento(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != this.Cor;
        }
        public bool ExisteMovimento()
        {
            bool[,] mat = MovimentosPossiveis();

            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j])
                        return true;
                }
            }
            return false;
        }
        public bool ValidarDestino(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }
    }
}
