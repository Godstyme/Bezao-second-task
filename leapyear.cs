using System;

public class LeapYear
{
    public static void leap_year(int year)
    {
        Console.WriteLine("The next 20 leap years are as follows: ");
        int count = 1;
        do
        {
            if((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) {
                Console.WriteLine($"{count}: {year}");
                count++;
            }
            year++;
        }
        while(count <= 20);
    }
    
    public static void Main(string[] currentYear)
    {
        leap_year(2020);
    }
}