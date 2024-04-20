DateTime date1 = new DateTime(2024, 3, 10);
DateTime date2 = new DateTime(2024, 3, 15);

DateCalculator calculator = new DateCalculator();
int daysBetween = calculator.CalculateDaysBetween(date1, date2); // Số ngày giữa hai ngày là: 5
Console.WriteLine("Số ngày giữa hai ngày là: " + daysBetween);

class DateCalculator
{
    public int CalculateDaysBetween(DateTime date1, DateTime date2)
    {
        // Ensure date1 is before date2 for easier calculation
        if (date1 > date2)
        {
            (date1, date2) = (date2, date1);
        }

        // Calculate the difference in years
        int yearDiff = date2.Year - date1.Year;

        // If dates are in the same year, simply calculate the difference in days
        if (yearDiff == 0)
        {
            return (date2 - date1).Days;
        }

        // Otherwise, iterate through the years in between and count leap years
        int days = (date2 - date1).Days;
        for (int year = date1.Year + 1; year < date2.Year; year++)
        {
            // Check for leap year
            if (IsLeapYear(year))
            {
                days++;
            }
        }
        return days;
    }
    private bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}