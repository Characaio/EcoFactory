using CoreSimulator.Blocks;
using CoreSimulator.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator
{
    public class Estruturas
    {
        static public Dictionary<Vector2i,Block> EstruturasDict { get; set; } = new Dictionary<Vector2i, Block>();

        static public Block get_block(Vector2i posição)
        {
            bool _ = EstruturasDict.TryGetValue(posição, out Block bloco);
            return bloco;
        }
        static public void Adicionar_posição(Vector2i pos, Block bloco)
        {
            EstruturasDict.Add(pos, bloco);
        }
        static public void Remover_bloco_em(Vector2i pos)
        {
            Block bloco = get_block(pos);
            foreach (Vector2i _pos in bloco.posições)
            {
                EstruturasDict.Remove(_pos);
            }
        }
        static public bool Pode_Colocar_Bloco(Vector2i pos)
        {

            if (EstruturasDict.ContainsKey(pos))
            {
                Console.WriteLine("Tem bloco na posição: " + pos);
                return false;
            }
            else
            {
                Console.WriteLine("Não tem bloco na posição: " + pos);
                return true;
            }
        }

        static public Block set_block(Block bloco)
        {
            bool temBloco = false;
            foreach (Vector2i pos in bloco.posições)
            {
                if (EstruturasDict.ContainsKey(pos))
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
