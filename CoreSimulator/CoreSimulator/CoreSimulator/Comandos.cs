using CoreSimulator.Blocks;
using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator
{
    public static class Comandos
    {


        public static void place_block(Block bloco)
        {
            Estruturas.set_block(
                bloco
                );
        }
        public static String read_block()
        {
            Block bloco = Estruturas.get_block(new Vector2i(2, 2));
            return bloco.TipoDeBloco + bloco.IdDoBloco.ToString();
        }
        public static String read_all_blocks()
        {
            String result = "";
            Console.WriteLine("All Keys: "+Estruturas.EstruturasDict.Keys.ToArray().ToString());
            foreach (var key in Estruturas.EstruturasDict.Keys)
            {
                var bloco = Estruturas.EstruturasDict[key];
                result += $"Block at {key}: {bloco.TipoDeBloco}+{bloco.IdDoBloco}\n";
            }
            return result;

        }
    }
}
