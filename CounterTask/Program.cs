﻿// See https://aka.ms/new-console-template for more information
using CounterTask;
class Program
{
    static public void printCounters(Counter[] counters)
    {
        foreach (var c in counters)
        {
            Console.WriteLine("{0} is at {1}", c.Name, c.Ticks);
        }
    }
    
    static void Main(string[] args)
    {
        Counter[] myCounters = new Counter[3];
        myCounters[0] = new Counter("Counter 1");
        myCounters[1] = new Counter("Counter 2");
        myCounters[2] = myCounters[0];

        for (int i = 1; i < 9; i++)
        {
            myCounters[0].Increment();
        }
        
        for (int i = 1; i < 14; i++)
        {
            myCounters[1].Increment();
        }

        printCounters(myCounters);
        myCounters[2].Reset();
        printCounters(myCounters);
    }
}