using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CoreSimulator.Blocks
{
    public class Block
    {
        static long BlockId = 1l;
        public static Dictionary<int,List<Vector2i>> TAMANHOS = new Dictionary<int, List<Vector2i>>()
        {
            {1,new List<Vector2i>(){new Vector2i(0,0)}},

            {2,new List<Vector2i>(){new Vector2i(0,0),new Vector2i(1,0),
                                   new Vector2i(0,1),new Vector2i(1,1)}},

            {3,new List<Vector2i>(){new Vector2i(0,0),new Vector2i(1,0),new Vector2i(2,0),
                                   new Vector2i(0,1),new Vector2i(1,1),new Vector2i(2,1),
                                   new Vector2i(0,2),new Vector2i(1,2),new Vector2i(2,2)}},

            {4,new List<Vector2i>(){new Vector2i(0,0),new Vector2i(1,0),new Vector2i(2,0),new Vector2i(3,0),
                                   new Vector2i(0,1),new Vector2i(1,1),new Vector2i(2,1),new Vector2i(3,1),
                                   new Vector2i(0,2),new Vector2i(1,2),new Vector2i(2,2),new Vector2i(3,2),
                                   new Vector2i(0,3),new Vector2i(1,3),new Vector2i(2,3),new Vector2i(3,3)} }
        };
        public List<Vector2i> Tamanho { get; set; }
        public long IdDoBloco;
        public List<Vector2i> posições = new List<Vector2i>();
        public String TipoDeBloco;
        
        public Block(Vector2i posição, String tipoDeBloco,int _tamanho)
        {
            bool valido = true;

            Tamanho = TAMANHOS[_tamanho];

            foreach (Vector2i tam in Tamanho)
            {
                Vector2i posFinal = posição + tam;
                this.posições.Add(posFinal);
            }
            

            foreach (Vector2i pos in posições)
            {
                Estruturas.Adicionar_posição(pos, this);
            }

            this.TipoDeBloco = tipoDeBloco;
            this.IdDoBloco = BlockId;
            BlockId++;
        }
    }
}
