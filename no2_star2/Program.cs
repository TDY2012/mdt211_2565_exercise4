using System;

class Program
{
    static int CompareDate(int year1, int month1, int day1, int year2, int month2, int day2)
    {
        if(year1 == year2)
        {
            if(month1 == month2)
            {
                if(day1 == day2)
                {
                    return 0;
                }
                else if(day1 < day2)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else if(month1 < month2)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        else if(year1 < year2)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }

    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        if(CompareDate(year, month, day, 2019, 5, 1) > -1)
        {
            Console.WriteLine("Reiwa");
        }
        else if(CompareDate(year, month, day, 1989, 1, 8) > -1)
        {
            Console.WriteLine("Heisei");
        }
        else if(CompareDate(year, month, day, 1926, 12, 25) > -1)
        {
            Console.WriteLine("Showa");
        }
        else if(CompareDate(year, month, day, 1912, 7, 30) > -1)
        {
            Console.WriteLine("Taisho");
        }
        else
        {
            Console.WriteLine("Meiji");
        }
    }
}