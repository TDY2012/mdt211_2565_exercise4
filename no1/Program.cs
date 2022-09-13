using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input a number of stations: ");
        int station_count = int.Parse(Console.ReadLine());
        int cost;
        switch(station_count)
        {
            case 1:
                cost = 16;
                break;
            case 2:
                cost = 23;
                break;
            case 3:
                cost = 26;
                break;
            case 4:
                cost = 30;
                break;
            case 5:
                cost = 33;
                break;
            case 6:
                cost = 37;
                break;
            case 7:
                cost = 40;
                break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                cost = 44;
                break;
            default:
                cost = 59;
                break;
        }

        Console.WriteLine("Cost (THB): {0}", cost);
    }
}