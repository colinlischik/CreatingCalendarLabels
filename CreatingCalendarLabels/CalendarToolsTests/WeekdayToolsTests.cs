using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarTools.Tests
{
    [TestClass()]
    public class WeekdayToolsTests
    {
        /// <summary>
        /// This tests the getting of formatted week days for February 2019 and February 2020 in order to ensure leap year comparability and language selection.
        /// </summary>
        [TestMethod()]
        public void GetWeekDayFormattedForLanguageTest()
        {
            // Setting a supposed result
            Dictionary<int, string> SupposedResult2019 = new Dictionary<int, string>()
            {
                { 1, "Fr" },
                { 2, "Sa" },
                { 3, "So" },
                { 4, "Mo" },
                { 5, "Di" },
                { 6, "Mi" },
                { 7, "Do" },
                { 8, "Fr" },
                { 9, "Sa" },
                { 10, "So" },
                { 11, "Mo" },
                { 12, "Di" },
                { 13, "Mi" },
                { 14, "Do" },
                { 15, "Fr" },
                { 16, "Sa" },
                { 17, "So" },
                { 18, "Mo" },
                { 19, "Di" },
                { 20, "Mi" },
                { 21, "Do" },
                { 22, "Fr" },
                { 23, "Sa" },
                { 24, "So" },
                { 25, "Mo" },
                { 26, "Di" },
                { 27, "Mi" },
                { 28, "Do" }
            };
            Dictionary<int, string> SupposedResult2020 = new Dictionary<int, string>()
            {
                { 1, "Sa" },
                { 2, "So" },
                { 3, "Mo" },
                { 4, "Di" },
                { 5, "Mi" },
                { 6, "Do" },
                { 7, "Fr" },
                { 8, "Sa" },
                { 9, "So" },
                { 10, "Mo" },
                { 11, "Di" },
                { 12, "Mi" },
                { 13, "Do" },
                { 14, "Fr" },
                { 15, "Sa" },
                { 16, "So" },
                { 17, "Mo" },
                { 18, "Di" },
                { 19, "Mi" },
                { 20, "Do" },
                { 21, "Fr" },
                { 22, "Sa" },
                { 23, "So" },
                { 24, "Mo" },
                { 25, "Di" },
                { 26, "Mi" },
                { 27, "Do" },
                { 28, "Fr" },
                { 29, "Sa" }
            };

            // Testing the function
            Dictionary<int, string> WeekdaysFebruary2019 = WeekdayTools.GetWeekDayFormattedForLanguage(2019, 2, "ddd", "de-DE");
            Dictionary<int, string> WeekdaysFebruary2020= WeekdayTools.GetWeekDayFormattedForLanguage(2020, 2, "ddd", "de-DE");

            // Asserting the function
            Assert.AreEqual(SupposedResult2019.Count, WeekdaysFebruary2019.Count);
            for (int i = 0; i < WeekdaysFebruary2019.Count; i++)
            {
                Assert.AreEqual(SupposedResult2019[i + 1], WeekdaysFebruary2019[i + 1]);
            }
            Assert.AreEqual(SupposedResult2020.Count, WeekdaysFebruary2020.Count);
            for (int i = 0; i < WeekdaysFebruary2020.Count; i++)
            {
                Assert.AreEqual(SupposedResult2020[i + 1], WeekdaysFebruary2020[i + 1]);
            }
        }
    }
}