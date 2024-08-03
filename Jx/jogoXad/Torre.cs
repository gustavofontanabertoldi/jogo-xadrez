using Jx.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jx.jogoXad
{
    internal class Torre :Peca
    {
            public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
            {

            }
            public override string ToString()
            {
                return "T";
            }
        }
    }
