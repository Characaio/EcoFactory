using CoreSimulator.Blocks;
using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator
{
    public class MapGrid
    {
        private Dictionary<Vector2i, BgBlock> BgGrid = new Dictionary<Vector2i, BgBlock>();

        public void CriarMapa(int largura, int altura)
        {
            for (int x = 0; x < largura; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    Vector2i pos = new Vector2i(x, y);
                    BgGrid[pos] = new BgBlock();
                }
            }
        }

    }
}
