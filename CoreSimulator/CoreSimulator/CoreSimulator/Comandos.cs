using CoreSimulator.Blocks;
using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator
{
    public class Comandos
    {

        public void place_block()
        {
            Estruturas.set_block(new Block(
                new Vector2(2, 2),
                Block.Tamanho2x2,
                "Esteira"
                ));

        }
    }
}
