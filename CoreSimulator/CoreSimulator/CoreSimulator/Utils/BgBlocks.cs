using CoreSimulator.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator.Utils
{
    public class BgBlocks
    {
        public static BgBlock 
            grama = new BgBlock() { NomeDoBloco = 1, solido = false },
            terra = new BgBlock() { NomeDoBloco = 2, solido = false },
            pedra = new BgBlock() { NomeDoBloco = 3, solido = true },
            agua = new BgBlock() { NomeDoBloco = 4, solido = false },
            areia = new BgBlock() { NomeDoBloco = 5, solido = false };
    }
}
