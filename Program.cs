using System;
using System.Threading;

namespace Stopwatch{

class Program{

    public static void Main(string[] args){
        Menu();

    }

    static void PreStart(int time){
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go!");
        Thread.Sleep(1000);

        Start(time);

    }

    static void Menu(){

        Console.Clear();

        Console.WriteLine("Select the time: ");
        Console.WriteLine("Ex: 10m = 10 minutes");
        Console.WriteLine("M - Minutes");
        Console.WriteLine("S - Seconds");
        Console.WriteLine("0 - Exit");

        string choose = Console.ReadLine().ToLower();

        char type = char.Parse(choose.Substring(choose.Length - 1,1));
        int time = int.Parse(choose.Substring(0,choose.Length - 1));

        int multiplier = 1;

        if (type == 'm'){
            multiplier = 60;
        }

        PreStart(time * multiplier);

    }
    
    static void Start(int time){
        
        int currentTime = 0;

        while(currentTime != time){
            
            Console.Clear();
            currentTime ++;
            Console.WriteLine(format: "Time: {0}", currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finished");

        Menu();

    }
}
}
