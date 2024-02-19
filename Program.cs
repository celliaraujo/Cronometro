﻿namespace Cronometro;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("------- Programa Cronômetro -------");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("S = Segundo | 10s = 10 segundos |");
        Console.WriteLine("...................................");
        Console.WriteLine("M = Minuto | 1m = 1 minuto |");
        Console.WriteLine("...................................");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Quanto tempo deseja contar?");
        Console.WriteLine("-----------------------------------");

        string data = Console.ReadLine().ToLower();
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronômetro finalizado...");
        Thread.Sleep(2500);

    }
}