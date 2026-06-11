using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CoreSimulator
{
    public class Ore
    {
        
        public String NomeDoMinerio { get; set; }
        public Color CorDoMinerio { get; set; }

        public Ore(String _NomeDoMinerio)
        {
            NomeDoMinerio = _NomeDoMinerio.ToLower();
        }
    }
}
