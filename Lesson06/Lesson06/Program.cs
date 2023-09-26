using System.Globalization;

namespace Lesson06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            #region DateTime

            //Console.WriteLine(DateTime.MinValue);
            //Console.WriteLine(DateTime.MaxValue);

            //DateTime today = DateTime.Today;
            //DateTime today1 = new DateTime(2023, 9, 26);
            //DateTime today2 = new DateTime(2023, 9, 26, 18, 55, 10);

            //Console.WriteLine(today);
            //Console.WriteLine(today1);
            //Console.WriteLine(today2);

            //Console.WriteLine();
            //Console.WriteLine("--- Today details ---");
            //Console.WriteLine(today.Day);
            //Console.WriteLine(today.DayOfWeek);
            //Console.WriteLine(today.DayOfYear);
            //Console.WriteLine(today.Month);
            //Console.WriteLine(today.Year);
            //Console.WriteLine(today.Hour);
            //Console.WriteLine(today.Minute);
            //Console.WriteLine(today.Second);

            //Console.WriteLine();
            //Console.WriteLine("---- Methods ----");

            //Console.WriteLine(today.AddDays(1));
            //Console.WriteLine(today.AddMonths(1));
            //Console.WriteLine(today.AddYears(1));
            //Console.WriteLine(today.AddHours(1));
            //Console.WriteLine(today.AddMinutes(1));
            //Console.WriteLine(today.AddSeconds(1));
            //Console.WriteLine(today.AddDays(-1));
            //Console.WriteLine(today.AddMonths(-1));
            //Console.WriteLine(today.AddYears(-1));
            //Console.WriteLine(today.AddHours(-1));
            //Console.WriteLine(today.AddMinutes(-1));
            //Console.WriteLine(today.AddSeconds(-1));
            //Console.WriteLine(today.AddDays(DateTime.MaxValue.Day));

            #endregion

            #region DateOnly

            //Console.WriteLine();
            //Console.WriteLine("--- Date only ---");

            //Console.WriteLine(DateOnly.MinValue);
            //Console.WriteLine(DateOnly.MaxValue);

            //DateOnly date = new DateOnly();
            //DateOnly date1 = new DateOnly(2023, 9, 26);
            //DateOnly date2 = new DateOnly(2023, 9, 26, new GregorianCalendar());
            //DateOnly date3 = new DateOnly(2023, 9, 26, new ChineseLunisolarCalendar());
            //DateOnly date4 = new DateOnly(2023, 9, 26, new HijriCalendar());

            //Console.WriteLine(date);
            //Console.WriteLine(date1);
            //Console.WriteLine(date2);
            //Console.WriteLine(date3);
            //Console.WriteLine(date4);

            #endregion

            #region TimeOnly

            //Console.WriteLine();
            //Console.WriteLine("--- Time Only ---");

            //Console.WriteLine(TimeOnly.MinValue);
            //Console.WriteLine(TimeOnly.MaxValue);

            //Console.WriteLine();
            //Console.WriteLine("---- objects ----");

            //TimeOnly time = new TimeOnly();
            //TimeOnly time1 = new TimeOnly(10_000_000_000);
            //TimeOnly time2 = new TimeOnly(10, 2, 5);
            //TimeOnly time3 = new TimeOnly(10, 2, 5, 999);

            //Console.WriteLine(time);
            //Console.WriteLine(time1);
            //Console.WriteLine(time2);
            //Console.WriteLine(time3);

            //Console.WriteLine();

            #endregion
        }
    }
}