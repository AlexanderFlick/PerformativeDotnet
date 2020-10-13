using System;
using System.Collections.Generic;
using System.Text;

namespace PerformativeDotnet
{
    public class DateParser
    {
        public int GetYearFromDateTime(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);
            return dateTime.Year;
        }

        public int GetYearFromSplit(string dateTimeAsString)
        {
            var splitOnHyphen = dateTimeAsString.Split("-");
            return int.Parse(splitOnHyphen[0]);
        }
    }
}
