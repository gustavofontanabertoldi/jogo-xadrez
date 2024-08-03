using Jx;
using Jx.tabuleiro;
using Jx.jogoXad;

internal class Program
{
    private static void Main(string[] args)
    {

        Posicao p;
        Tabuleiro tab = new Tabuleiro(8, 8);


        tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

        Tela.imprimirTabuliro(tab);

        Console.WriteLine(tab);
    }
}