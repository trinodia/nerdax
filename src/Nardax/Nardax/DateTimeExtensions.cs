using System;

namespace Nardax
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Avrunda datum neråt
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static DateTime Floor(this DateTime dateTime, TimeSpan timeSpan)
        {xxxxxxxxxxx
            var ticks = dateTime.Ticks / timeSpan.Ticks;
            return new DateTime(ticks * timeSpan.Ticks);
        }
        ddddddddddddddddddddd
        /// <summary>
        /// Avrunda datum
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static DateTime Round(this DateTime dateTime, TimeSpan timeSpan)
        {
            var ticks = (dateTime.Ticks + (timeSpan.Ticks / 2) + 1) / timeSpan.Ticks;
            return new DateTime(ticks * timeSpan.Ticks);
        }

        /// <summary>
        /// Avrunda datum uppåt
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static DateTime Ceiling(this DateTime dateTime, TimeSpan timeSpan)
        {
            var ticks = (dateTime.Ticks + timeSpan.Ticks - 1) / timeSpan.Ticks;
            return new DateTime(ticks * timeSpan.Ticks);
        }

        /// <summary>
        /// Returnera datumet som är minst
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime Min(this DateTime dateTime, DateTime value)
        {
            return dateTime <= value ? dateTime : value;
        }

        /// <summary>
        /// Returnera datumet som är störst
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime Max(this DateTime dateTime, DateTime value)
        {
            return dateTime >= value ? dateTime : value;
        }

        /// <summary>
        /// Returnerar hur många minuter det är från anget datum
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="from"></param>
        /// <returns></returns>
        public static int MinutesFrom(this DateTime dateTime, DateTime from)
        {
            var timeSpan = (dateTime - from);
            return Convert.ToInt32(timeSpan.TotalMinutes);
        }

        public static int SecondsFrom(this DateTime dateTime, DateTime from)
        {
            var timeSpan = (dateTime - from);
            return Convert.ToInt32(timeSpan.TotalSeconds);
        }

        public static DateTime GetUnixEpoch()
        {
            return new DateTime(1970, 1, 1);
        }

        public static int MinutesFromUnixEpoch(this DateTime dateTime)
        {
            return dateTime.MinutesFrom(GetUnixEpoch());
        }
       
        public static int SecondsFromUnixEpoch(this DateTime dateTime)
        {
            return dateTime.SecondsFrom(GetUnixEpoch());
        }

        public static double MillisecondOfDay(this DateTime dateTime)
        {
            return dateTime.TimeOfDay.TotalMilliseconds;
        }

        public static DateTime Midnight(this DateTime dateTime)
        {
            return dateTime.Date;
        }

        public static DateTime Noon(this DateTime dateTime)
        {
            return dateTime.SetTime(12);
        }

        public static DateTime SetTime(this DateTime dateTime, int hour)
        {
            return SetTime(dateTime, hour, 0, 0, 0);
        }

        public static DateTime SetTime(this DateTime dateTime, int hour, int minute)
        {
            return SetTime(dateTime, hour, minute, 0, 0);
        }

        public static DateTime SetTime(this DateTime dateTime, int hour, int minute, int second)
        {
            return SetTime(dateTime, hour, minute, second, 0);
        }

        public static DateTime SetTime(this DateTime dateTime, int hour, int minute, int second, int millisecond)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hour, minute, second, millisecond);
        }
    }
}
