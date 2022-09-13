using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int wallWidth;
        if(int.TryParse(input, out wallWidth))
        {
            if(wallWidth < 1)
            {
                Console.WriteLine("Please input a positive integer.");
            }
            else if(wallWidth % 2 != 0)
            {
                Console.WriteLine("Please input an even positive integer.");
            }
            else
            {
                Console.WriteLine("{0}, {1}", wallWidth/2, wallWidth/2 + 1);
            }
        }
        else
        {
            Console.WriteLine("Please input an integer.");
        }
    }
}