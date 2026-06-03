using CoreSimulator.Blocks;
using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator
{
    public class Estruturas
    {
        static public Dictionary<Vector2,Block> Estrutura { get; set; }

        static public Block get_block(Vector2 posição)
        {
            Estrutura.TryGetValue(posição, out Block bloco);
            return bloco;
        }
        static public Block set_block(Block bloco)
        {
            bool temBloco = false;
            foreach (Vector2 pos in bloco.posições)
            {
                if (Estrutura.ContainsKey(pos))
                {
                    temBloco = true;
                }
            }
            if (temBloco)
            {
            }
            return bloco;
        }
    }
}
