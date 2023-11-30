namespace Algorithm_Csharp;

public class Week
{
    public string solution(int a, int b)
    {
        return GetDayOfWeek(a, b);
    }

    public static string GetDayOfWeek(int month, int day)
    {
        // Create a DateTime for the given date in 2016
        DateTime date = new DateTime(2016, month, day);

        // Get the DayOfWeek enum value
        DayOfWeek dow = date.DayOfWeek;

        // Map DayOfWeek to the required string format
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