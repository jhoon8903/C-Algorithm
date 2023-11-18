using System;
public class Solution 
{
    public string solution(int a, int b)
    {
        return Calculate(a, b);
    }

    public static string Calculate(int month, int day)
    {
        DateTime date = new DateTime(2016, month, day);
        DayOfWeek dow = date.DayOfWeek;
        switch (dow)
        {
            case DayOfWeek.Sunday:
                return "SUN";
            case DayOfWeek.Monday:
                return "MON";
            case DayOfWeek.Tuesday:
                return "TUE";
            case DayOfWeek.Wednesday:
                return "WED";
            case DayOfWeek.Thursday:
                return "THU";
            case DayOfWeek.Friday:
                return "FRI";
            case DayOfWeek.Saturday:
                return "SAT";
            default:
                return "";
        }
    }
}