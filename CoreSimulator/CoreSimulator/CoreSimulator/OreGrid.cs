using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CoreSimulator
{
    public class OreGrid
    {
        public static List<String> OreNames = new List<String>() {"cobre", "chumbo", "carvao", "titanio"  };
        public static Dictionary<Vector2i,Ore> Oregrid = new Dictionary<Vector2i,Ore>();
        public static Dictionary<String,char> NameToChar = new Dictionary<String, char>()
        {
            {"cobre", 'C'},
            {"chumbo", 'H'},
            {"carvao", 'K'},
            {"titanio", 'T' }
        };
        public static void create_ore_grid(Vector2i gridSize)
        {
            for (int x = 0; x < gridSize.X; x++)
            {
                for (int y = 0; y < gridSize.Y; y++)
                {
                    Random rand = new Random();
                    int randnumber = rand.Next(0, 20);
                    if (randnumber > 15)
                    {
                        String ore_name = OreNames.Shuffle().First();
                        Ore ore = new Ore(ore_name);
                        Vector2i key = new Vector2i(x, y);
                        Oregrid[key] = ore;
                    }
                    //Console.WriteLine(ore.NomeDoMinerio);
                }
            }
        }

        public static String read_ores()
        {
            String result = "";
            foreach (var key in Oregrid.Keys)
            {
                var ore = Oregrid[key];
                result += $"Ore at {key}: {NameToChar[ore.NomeDoMinerio]}\n";
            }
            return result;
        }
    }
}
