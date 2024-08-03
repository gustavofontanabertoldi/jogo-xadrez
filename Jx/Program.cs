using Jx;
using Jx.tabuleiro;

internal class Program
{
    private static void Main(string[] args)
    {

        Posicao p;
        Tabuleiro tab = new Tabuleiro(8, 8); 

        Tela.imprimirTabuliro(tab);

        Console.WriteLine(tab);
    }
}