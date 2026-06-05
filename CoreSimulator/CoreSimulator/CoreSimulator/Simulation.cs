using CoreSimulator.Blocks;
using CoreSimulator.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace CoreSimulator
{
    public class Simulation
    {
        public long tickCount = 0;
        public bool IsRunning { get; private set; } = true;
        public bool debug { get; private set; } = false;
        public String HelpString = "Available commands:Gerar Mapa, Place Block, Read Block, Read All Blocks exit, stop, start, debug, help";
        public void Start()
        {
            Console.WriteLine(HelpString);

            Thread SimulatorThread = new Thread(Simulation_Loop);
            SimulatorThread.Start();

            Input_Loop();
        }
        public void Input_Loop()
        {
            while (IsRunning)
            {
                String Input = Console.ReadLine();
                Console.WriteLine("Input: " + Input);
                Handle_Input(Input.ToLower());
            }
            return;
        }
        public void Handle_Input(String Input)
        {
            switch (Input)
            {
                case "exit":
                    IsRunning = false;
                    break;
                case "stop":
                    IsRunning = false;
                    break;
                case "start":
                    IsRunning = true;
                    break;
                case "help":
                    Console.WriteLine(HelpString);
                    break;
                case "debug":
                    debug = !debug;
                    Console.WriteLine("Debug mode: " + (debug ? "ON" : "OFF"));
                    break;
                case "gerar mapa":
                    Console.WriteLine("Gerando mapa...");
                    // Aqui você pode adicionar a lógica para gerar o mapa
                    break;
                case "place block":
                    Console.WriteLine("Qual é a posição X?");
                    int X = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual é a posição Y?");
                    int Y = int.Parse(Console.ReadLine());

                    Vector2i pos = new Vector2i(X, Y);

                    Console.WriteLine("Qual é o tipo do bloco?");
                    String _blockType = Console.ReadLine();
                    if (_blockType == null || _blockType == "")
                    {
                        _blockType = "Nulo";
                    }

                    Console.WriteLine("Qual é o tamanho do bloco? (ex: 1x1 = 1, 2x2 = 2, 3x3 = 3)");
                    int _blockSize = int.Parse(Console.ReadLine());
                    Comandos.place_block(new Block(pos, _blockType, _blockSize));

                    Console.WriteLine("Block placed at " + pos.ToString());
                    break;
                case "read block":
                    String blockType = Comandos.read_block();
                    Console.WriteLine("Block at (2, 2) is of type: " + blockType);
                    break;
                case "read all blocks":
                    Console.WriteLine(Comandos.read_all_blocks());
                    break;
                default:
                    Console.WriteLine("Unknown command: " + Input);
                    break;
            }
        }
        public void Simulation_Loop()
        {
            const double baseTick = 60f;
            const double speed = 0.1f;
            const double TPS = baseTick * speed;
            double tickInterval = 1f / TPS;

            var stopwatch = Stopwatch.StartNew();
            double preciousTime = stopwatch.Elapsed.TotalSeconds;
            double accumulator = 0;

            while (IsRunning)
            {
                double currentTime = stopwatch.Elapsed.TotalSeconds;
                double deltaTime = currentTime - preciousTime;
                preciousTime = currentTime;

                accumulator += deltaTime;

                while (accumulator >= tickInterval)
                {
                    Tick();
                    tickCount++;
                    accumulator -= tickInterval;
                }
            }
        }
        public void Tick()
        {
            if (!debug) return;
            Console.WriteLine("Tick" + tickCount.ToString());
        }

    }
}
