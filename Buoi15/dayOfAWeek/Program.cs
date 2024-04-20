DateTime date1 = new DateTime(2024, 3, 10);
DateTime date2 = new DateTime(2024, 3, 15);

DateCalculator calculator = new DateCalculator();
string dayOfWeek = calculator.DetermineDayOfWeek(date1);
Console.WriteLine("Ngày 10/3/2024 là thứ: " + dayOfWeek); // Chủ nhật

string dayOfWeek2 = calculator.DetermineDayOfWeek(date2);
Console.WriteLine("Ngày 15/3/2024 là thứ: " + dayOfWeek2); // Thứ 6

class DateCalculator
{
    public string DetermineDayOfWeek(DateTime date)
    {
        DayOfWeek dayOfWeek = date.DayOfWeek;
        switch (dayOfWeek)
        {
            case DayOfWeek.Sunday:
                return "Sunday";
            case DayOfWeek.Monday:
                return "Monday";
            case DayOfWeek.Tuesday:
                return "Tuesday";
            case DayOfWeek.Wednesday:
                return "Wednesday";
            case DayOfWeek.Thursday:
                return "Thursday";
            case DayOfWeek.Friday:
                return "Friday";
            case DayOfWeek.Saturday:
                return "Saturday";
            default:
                return "Invalid DayOfWeek";
        }
    }
}