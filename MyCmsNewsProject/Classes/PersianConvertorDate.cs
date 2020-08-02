using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using ABlue.PersianDateTime;

namespace MyCmsNewsProject
{
    public static class PersianConvertorDate
    {
        //public static string ToShamsi(this DateTime value)
        //{
        //    PersianCalendar pc = new PersianCalendar();
        //    return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
        //           pc.GetDayOfMonth(value).ToString("00");
        //}
        public static string ToShamsi(this DateTime value)
        {
            PersianDateTime pd=new PersianDateTime(value);
            return pd.ToLongDateTimeString();
        }
        public static string ToShamsiDate(this DateTime value)
        {
            PersianDateTime pd = new PersianDateTime(value);
            return pd.ToLongDateString();
        }
    }
}