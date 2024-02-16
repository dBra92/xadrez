using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal class Tabuleiros
    {

        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public Tabuleiros(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }
        public Peca PecaM(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

    }
}
