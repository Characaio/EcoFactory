using CoreSimulator.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSimulator.Utils
{
    public class BgBlocks
    {
        public static BgBlockType 
            grama = new BgBlockType() { NomeDoBloco = "Grama", solido = false },
            terra = new BgBlockType() { NomeDoBloco = "Terra", solido = false },
            pedra = new BgBlockType() { NomeDoBloco = "Pedra", solido = true },
            agua = new BgBlockType() { NomeDoBloco = "Agua", solido = false },
            areia = new BgBlockType() { NomeDoBloco = "Areia", solido = false };
        public static BgBlockType[] blocos = new BgBlockType[] { grama, terra, pedra, agua, areia };
        public static char converter_nome_para_caractere(String TipoDeBloco)
        {
            char caractere = ' ';

            switch (TipoDeBloco)
            {
                case "Grama":
                    caractere = 'G';
                    break;
                case "Terra":
                    caractere = 'T';
                    break;
                case "Pedra":
                    caractere = 'P';
                    break;
                case "Agua":
                    caractere = 'A';
                    break;
                case "Areia":
                    caractere = 'S';
                    break;
            }
            return caractere;
        }
    }
}
