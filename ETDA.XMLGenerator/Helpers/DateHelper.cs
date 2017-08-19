using System;
using System.Globalization;

namespace ETDA.XMLGenerator.Helpers
{
    public static class DateHelper
    {
        public static DateTime Convert2Date(string dateTime)
        {
            // dd/MM/yyyy
            string[] array = dateTime.Split('/');
            string nDateTime = array[2] + '-' + array[1] + '-' + array[0];
            return DateTime.Parse(nDateTime);
        }

        public static DateTime Convert2DateFromTH(string dateTime)
        {
            // dd/MM/yyyy TH
            string[] array = dateTime.Split('/');
            string nDateTime = array[2] + '-' + array[1] + '-' + array[0];
            return DateTime.Parse(nDateTime, new CultureInfo("th-TH"));
        }

        public static string Convert2En(string dateTime)
        {
            return DateTime.Parse(dateTime).ToString("dd/MM/yyyy", new CultureInfo("en-US"));
        }

        public static string Convert2Th(string dateTime)
        {
            return DateTime.Parse(dateTime).ToString("dd/MM/yyyy", new CultureInfo("th-TH"));
        }
    }
}