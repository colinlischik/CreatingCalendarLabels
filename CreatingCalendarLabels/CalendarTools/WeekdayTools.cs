using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalendarTools
{
    public static class WeekdayTools
    {
        /// <summary>
        /// Returns a formatted dictionary of weekdays for each day within the given year and month. The names will be formatted dependent on the given language.
        /// </summary>
        /// <param name="year">The given year.</param>
        /// <param name="month">The given month.</param>
        /// <param name="dayFormat">The format of the day, full format or short</param>
        /// <param name="languageDefinition">The language in which the weekdays should be returned.</param>
        /// <returns>A dictionary with all days within the given month, that are including the named weekdays in the given language.</returns>
        public static Dictionary<int, string> GetWeekDayFormattedForLanguage(int year, int month, string dayFormat, string languageDefinition)
        {
            // Create the dictionary that should be returned
            Dictionary<int, string> Weekdays = new Dictionary<int, string>();

            // Get the number of days in the given month
            int Days = DateTime.DaysInMonth(year, month);

            // Fill the dictionary with all days and the matching week day
            for (int day = 1; day <= Days; day++)
            {
                // Get the week day for the current day 
                string Weekday = new DateTime(year, month, day).ToString(dayFormat, new CultureInfo(languageDefinition));

                // Set the dictionary with the weekdays
                Weekdays[day] = Weekday;
            }

            return Weekdays;
        }

    }
}
