using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tabuleiro;

namespace Xadrez_pt2
{
    internal class Tela
    {
        public static void ImprimirTab(Tabuleiros tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.PecaM(i, j) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(tab.PecaM(i, j) +" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
