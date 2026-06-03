using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator.Blocks
{
    public class Block
    {
        static long BlockId = 1l;
        public static List<Vector2> Tamanho2x2 = new List<Vector2>()
        {
            new Vector2(0,0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1)
        };
        public List<Vector2> Tamanho { get; set; }
        public long IdDoBloco;
        public List<Vector2> posições;
        public String TipoDeBloco;

        public Block(Vector2 posição,List<Vector2> _tamanho, String tipoDeBloco)
        {
            Tamanho = _tamanho;
            foreach (Vector2 tam in Tamanho)
            {
                this.posições.Add(posição + tam);
            }
            this.TipoDeBloco = tipoDeBloco;
            this.IdDoBloco = BlockId;
            BlockId++;
        }
    }
}
