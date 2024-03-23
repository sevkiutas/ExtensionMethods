using System.Collections.Generic;
using System;

namespace TestProject.Extensions
{
    public static class DateTimeExtensions
    {

        public static DateTime CalculateLastPaymentDate(this DateTime date, List<DateTime> holidays)
        {
            while (IsWeekendOrHoliday(date, holidays))
            {

                date = date.AddDays(1);

            }
            return date;
        }
        private static bool IsWeekendOrHoliday(DateTime date, List<DateTime> holidays)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday || holidays?.Contains(date) == true;
        }
    }
}
