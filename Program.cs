using System;

namespace DateTime_ExtensionMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var dt = DateTime.Now;
			dt = dt.AddDays(2);
			Console.WriteLine(dt.DayOfWeek);
			Console.WriteLine($"Is week end: {dt.IsWeekEnd()}");
			Console.WriteLine($"Is week day: {dt.IsWeekDay()}");
			Console.ReadKey();
		}
	}
}
