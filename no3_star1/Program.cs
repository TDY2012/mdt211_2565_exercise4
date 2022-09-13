using System;

class Program
{
    static void Main(string[] args)
    {
        int disasterMagnitude = int.Parse(Console.ReadLine());
        switch(disasterMagnitude)
        {
            case 1:
            case 3:
            case 5:
            case 7:
                Console.WriteLine("yellow");
                break;
        }

        switch(disasterMagnitude)
        {
            case 2:
            case 3:
            case 6:
            case 7:
                Console.WriteLine("orange");
                break;
        }

        switch(disasterMagnitude)
        {
            case 4:
            case 5:
            case 6:
            case 7:
                Console.WriteLine("red");
                break;
        }
    }
}