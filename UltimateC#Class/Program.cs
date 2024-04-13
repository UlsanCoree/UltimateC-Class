using System;
using System.Runtime.InteropServices;

class UltimateClass
{
    static void Main()
    {
        Console.WriteLine("연도를 입력하세요");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("월을 입력하세요");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("일을 입력하세요");
        int day = int.Parse(Console.ReadLine());

        string formatData = FormatDate(year, month, day);
        Console.WriteLine(formatData);
    }

    public static string FormatDate(int year, int month, int day)
    {
        return $"{year}/{month:D2}/{day:D2}";
    }
}
