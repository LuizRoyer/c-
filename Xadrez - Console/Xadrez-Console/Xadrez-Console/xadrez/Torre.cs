using Xadrez_Console.tabuleiro;
using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);
            // Validar Casa Acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && base.ValidarMovimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) break;

                pos.Linha -= 1;
            }

            // Validar Casa Abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && base.ValidarMovimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) break;

                pos.Linha += 1;
            }
            // Validar Casa Adireita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && base.ValidarMovimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) break;

                pos.Coluna += 1;
            }
            // Validar Casa A Esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && base.ValidarMovimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor) break;

                pos.Coluna -= 1;
            }
            return mat;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}

