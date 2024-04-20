DateTime dateOfBirth = new DateTime(2000, 10, 25);
DateCalculator calculator = new DateCalculator();

DateInfo dateInfo = calculator.GetDateInfo(dateOfBirth);
// in ra thông tin
dateInfo.PrintInfo();

class DateCalculator
{
    public DateInfo GetDateInfo(DateTime dateOfBirth)
    {
        return new DateInfo(GetAge(dateOfBirth), GetHoroscope(dateOfBirth));
    }

    public string GetHoroscope(DateTime dateOfBirth)
    {
        int month = dateOfBirth.Month;
        int day = dateOfBirth.Day;

        // Define horoscope sign ranges (adjust for variations if needed)
        var signs = new Dictionary<string, (Tuple<int, int>, Tuple<int, int>)>
        {
            ["Capricorn"] = (new Tuple<int, int>(12, 22), new Tuple<int, int>(1, 19)),
            ["Aquarius"] = (new Tuple<int, int>(1, 20), new Tuple<int, int>(2, 18)),
            ["Pisces"] = (new Tuple<int, int>(2, 19), new Tuple<int, int>(3, 20)),
            ["Aries"] = (new Tuple<int, int>(3, 21), new Tuple<int, int>(4, 19)),
            ["Taurus"] = (new Tuple<int, int>(4, 20), new Tuple<int, int>(5, 20)),
            ["Gemini"] = (new Tuple<int, int>(5, 21), new Tuple<int, int>(6, 20)),
            ["Cancer"] = (new Tuple<int, int>(6, 21), new Tuple<int, int>(7, 22)),
            ["Leo"] = (new Tuple<int, int>(7, 23), new Tuple<int, int>(8, 22)),
            ["Virgo"] = (new Tuple<int, int>(8, 23), new Tuple<int, int>(9, 22)),
            ["Libra"] = (new Tuple<int, int>(9, 23), new Tuple<int, int>(10, 22)),
            ["Scorpio"] = (new Tuple<int, int>(10, 23), new Tuple<int, int>(11, 21)),
            ["Sagittarius"] = (new Tuple<int, int>(11, 22), new Tuple<int, int>(12, 21)),
        };

        foreach (var sign in signs)
        {
            if ((month == sign.Value.Item1.Item1 && day >= sign.Value.Item1.Item2) ||
                (month == sign.Value.Item2.Item1 && day <= sign.Value.Item2.Item2))
            {
                return sign.Key;
            }
        }

        return "Invalid date";
    }


    public int GetAge(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Now;
        int age = today.Year - dateOfBirth.Year;
        if (dateOfBirth > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }
}

class DateInfo
{
    private int Tuoi;
    private string CungHoangDao { get; set; }

    public DateInfo()
    {
        this.Tuoi = 0;
        this.CungHoangDao = string.Empty;
    }

    public DateInfo(int tuoi, string cungHoangDao)
    {
        this.Tuoi = tuoi;
        this.CungHoangDao = cungHoangDao;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Tuoi: {0}, Cung hoang dao: {1}", this.Tuoi, this.CungHoangDao);
    }
}