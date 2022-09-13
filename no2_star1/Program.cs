using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        DateTime date = new DateTime(year, month, day);
        JapaneseCalendar calendar = new JapaneseCalendar();
        int era = calendar.GetEra(date);
        switch(era)
        {
            case 1:
                Console.WriteLine("Meiji");
                break;
            case 2:
                Console.WriteLine("Taisho");
                break;
            case 3:
                Console.WriteLine("Showa");
                break;
            case 4:
                Console.WriteLine("Heisei");
                break;
            case 5:
                Console.WriteLine("Reiwa");
                break;
        }
    }
}