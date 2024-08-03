using Jx.tabuleiro;
using System;
using System.Collections.Generic;
using Jx.tabuleiro;

namespace Jx.jogoXad
{
    internal class Rei : Peca
    {
        public Rei (Tabuleiro tab, Cor cor) : base (cor, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
