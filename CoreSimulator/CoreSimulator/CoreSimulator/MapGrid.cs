using CoreSimulator.Blocks;
using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator
{
    public static class MapGrid
    {
        public static BgBlock[,] mapa;

        public static void CriarMapa(Vector2i gridSize)
        {
            mapa = new BgBlock[gridSize.X, gridSize.Y];

            for (int x = 0; x < gridSize.X; x++)
            {
                for (int y = 0; y < gridSize.Y; y++)
                {
                    Vector2i pos = new Vector2i(x, y);
                    BgBlock bloco = new BgBlock();
                    bloco.posicao = pos;
                    bloco.tipo = BgBlocks.blocos.Shuffle().First();
                    mapa[x, y] = bloco;
                }
            }
        }
        public static String ReadMapa()
        {
            String result = "";
            for (int x = 0; x < mapa.GetLength(0); x++)
            {
                result += "\n";
                for (int y = 0; y < mapa.GetLength(1); y++)
                {
                    result += BgBlocks.converter_nome_para_caractere(mapa[x, y].tipo.NomeDoBloco)+" ";
                }
            }
            return result;
        }

    }
}
