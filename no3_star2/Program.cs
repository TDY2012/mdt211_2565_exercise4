using System;

class Program
{
    static void Main(string[] args)
    {
        int disasterMagnitude = int.Parse(Console.ReadLine());
        if((disasterMagnitude & 1 << 0) > 0)
        {
            Console.WriteLine("yellow");
        }

        if((disasterMagnitude & 1 << 1) > 0)
        {
            Console.WriteLine("orange");
        }

        if((disasterMagnitude & 1 << 2) > 0)
        {
            Console.WriteLine("red");
        }
    }
}