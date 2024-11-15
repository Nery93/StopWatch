using System;
using System.Diagnostics;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.Write("Quanto tempo deseja contar: ");

            string data = Console.ReadLine() ?? "0".ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            if (type == 0)
                System.Environment.Exit(0);
            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(2000);

            Start(time);
        }

        static void Start(int time)
        {

            int currentTime = 0; // Contador de tempo
            while (currentTime != time) // Enquanto o contador de tempo não for igual ao tempo desejado
            {
                currentTime++; // Incrementa o contador de tempo
                Console.Write(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Time is over");
            Thread.Sleep(2000);
            Menu();





        }
    }
}