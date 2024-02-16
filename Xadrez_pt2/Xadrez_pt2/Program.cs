using Tabuleiro;
using Xadrez_pt2;

namespace Princip;
class Program
{
    public static void Main(string[] args)
    {
        Tabuleiros tab = new(8, 8);

        Tela.ImprimirTab(tab);
    }
}