using System;
using System.Collections.Generic;
using System.Text;

namespace DateTime_ExtensionMethod
{
	static class DateTimeExtension
	{
		public static bool IsWeekEnd(this DateTime dt)
		{
			return dt.DayOfWeek == DayOfWeek.Friday || dt.DayOfWeek == DayOfWeek.Saturday; 
		}

		public static bool IsWeekDay(this DateTime dt)
		{
			return !IsWeekEnd(dt);
		}
	}
}
