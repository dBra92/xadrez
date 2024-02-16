using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tabuleiro;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; set; }
        public Tabuleiros Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiros tab)
        {
            Posicao = posicao;
            this.Cor = cor;
            this.Tab = tab;
            QtdMovimentos = 0;
        }
    }
}
