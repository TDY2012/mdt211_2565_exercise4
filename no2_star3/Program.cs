using System;

class Program
{
    static int CompareDate(ref int[] date1, ref int[] date2, int ptr)
    {
        if(ptr == date1.Length)
        {
            return 0;
        }

        if(date1[ptr] == date2[ptr])
        {
            return CompareDate(ref date1, ref date2, ptr+1);
        }
        else if(date1[ptr] < date2[ptr])
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
        int[] date = new int[3];
        date[0] = int.Parse(Console.ReadLine());
        date[1] = int.Parse(Console.ReadLine());
        date[2] = int.Parse(Console.ReadLine());

        int[] dateReiwa = new int[3]{ 2019, 5, 1 };
        int[] dateHeisei = new int[3]{ 1989, 1, 8 };
        int[] dateShowa = new int[3]{ 1926, 12, 25 };
        int[] dateTaisho = new int[3]{ 1912, 7, 30 };

        string eraName = "Meiji";
        if(CompareDate(ref date, ref dateReiwa, 0) > -1)
        {
            eraName = "Reiwa";
        }
        else if(CompareDate(ref date, ref dateHeisei, 0) > -1)
        {
            eraName = "Heisei";
        }
        else if(CompareDate(ref date, ref dateShowa, 0) > -1)
        {
            eraName = "Showa";
        }
        else if(CompareDate(ref date, ref dateTaisho, 0) > -1)
        {
            eraName = "Taisho";
        }
        Console.WriteLine(eraName);
    }
}