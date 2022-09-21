﻿// <copyright file = "DateTimeExtensions.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "ConvertSwitchStatementToSwitchExpression" ) ]
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Verifies if the object is a startDate
        /// </summary>
        /// <param name = "date" >
        /// The date.
        /// </param>
        /// <returns>
        /// The <see cref = "bool"/>
        /// </returns>
        public static bool IsDate( this object date )
        {
            return DateTime.TryParse( date.ToString( ), out _ );
        }

        /// <summary>
        /// Returns a startDate in the past by days.
        /// </summary>
        /// <param name = "days" >
        /// The days.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime DaysAgo( this int days )
        {
            TimeSpan _timeSpan = new TimeSpan( days, 0, 0, 0 );
            return DateTime.Now.Subtract( _timeSpan );
        }

        /// <summary>
        /// Returns a startDate in the future by days.
        /// </summary>
        /// <param name = "days" >
        /// The days.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime DaysFromNow( this int days )
        {
            TimeSpan t = new TimeSpan( days, 0, 0, 0 );
            return DateTime.Now.Add( t );
        }

        /// <summary>
        /// Returns a startDate in the past by hours.
        /// </summary>
        /// <param name = "hours" >
        /// The hours.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime HoursAgo( this int hours )
        {
            TimeSpan t = new TimeSpan( hours, 0, 0 );
            return DateTime.Now.Subtract( t );
        }

        /// <summary>
        /// Returns a startDate in the future by hours.
        /// </summary>
        /// <param name = "hours" >
        /// The hours.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime HoursFromNow( this int hours )
        {
            TimeSpan t = new TimeSpan( hours, 0, 0 );
            return DateTime.Now.Add( t );
        }

        /// <summary>
        /// Returns a startDate in the past by minutes
        /// </summary>
        /// <param name = "minutes" >
        /// The minutes.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime MinutesAgo( this int minutes )
        {
            TimeSpan t = new TimeSpan( 0, minutes, 0 );
            return DateTime.Now.Subtract( t );
        }

        /// <summary>
        /// Returns a startDate in the future by minutes.
        /// </summary>
        /// <param name = "minutes" >
        /// The minutes.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime MinutesFromNow( this int minutes )
        {
            TimeSpan t = new TimeSpan( 0, minutes, 0 );
            return DateTime.Now.Add( t );
        }

        /// <summary>
        /// Gets a startDate in the past according to seconds
        /// </summary>
        /// <param name = "seconds" >
        /// The seconds.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime SecondsAgo( this int seconds )
        {
            TimeSpan t = new TimeSpan( 0, 0, seconds );
            return DateTime.Now.Subtract( t );
        }

        /// <summary>
        /// Gets a startDate in the future by seconds.
        /// </summary>
        /// <param name = "seconds" >
        /// The seconds.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime SecondsFromNow( this int seconds )
        {
            TimeSpan t = new TimeSpan( 0, 0, seconds );
            return DateTime.Now.Add( t );
        }

        /// <summary>
        /// Checks to see if the startDate is a week day (Mon - Fri)
        /// </summary>
        /// <param name = "dateTime" >
        /// The date.
        /// </param>
        /// <returns>
        /// The <see cref = "bool"/>
        /// </returns>
        public static bool IsWeekDay( this DateTime dateTime )
        {
            return dateTime.DayOfWeek != DayOfWeek.Saturday
                && dateTime.DayOfWeek != DayOfWeek.Sunday;
        }

        /// <summary>
        /// Checks to see if the startDate is Saturday or Sunday
        /// </summary>
        /// <returns>
        /// The <see cref = "bool"/>
        /// </returns>
        public static bool IsWeekEnd( this DateTime dateTime )
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday
                || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        /// <summary>
        /// Counts the number of weekdays between two dates.
        /// </summary>
        /// <param name = "startDate" >
        /// The start time.
        /// </param>
        /// <param name = "endDate" >
        /// The end time.
        /// </param>
        /// <returns>
        /// </returns>
        public static int CountWeekDays( this DateTime startDate, DateTime endDate )
        {
            TimeSpan ts = endDate - startDate;
            Console.WriteLine( ts.Days );
            int cnt = 0;

            for( int i = 0; i < ts.Days; i++ )
            {
                DateTime dt = startDate.AddDays( i );

                if( dt.IsWeekDay( ) )
                {
                    cnt++;
                }
            }

            return cnt;
        }

        /// <summary>
        /// Counts the number of weekends between two dates.
        /// </summary>
        /// <param name = "startDate" >
        /// The start time.
        /// </param>
        /// <param name = "endDate" >
        /// The end time.
        /// </param>
        /// <returns>
        /// </returns>
        public static int CountWeekEnds( this DateTime startDate, DateTime endDate )
        {
            TimeSpan ts = endDate - startDate;
            int cnt = 0;

            for( int i = 0; i < ts.Days; i++ )
            {
                DateTime dt = startDate.AddDays( i );

                if( dt.IsWeekEnd( ) )
                {
                    cnt++;
                }
            }

            return cnt;
        }

        /// <summary>
        /// Diffs the specified startDate.
        /// </summary>
        /// <param name = "startDate" >
        /// The startDate one.
        /// </param>
        /// <param name = "endDate" >
        /// The startDate two.
        /// </param>
        /// <returns>
        /// </returns>
        public static TimeSpan Diff( this DateTime startDate, DateTime endDate )
        {
            TimeSpan t = startDate.Subtract( endDate );
            return t;
        }

        /// <summary>
        /// Returns a double indicating the number of days between two dates (past is
        /// negative)
        /// </summary>
        /// <param name = "dateone" >
        /// The startDate one.
        /// </param>
        /// <param name = "datetwo" >
        /// The startDate two.
        /// </param>
        /// <returns>
        /// </returns>
        public static double DiffDays( this string dateone, string datetwo )
        {
            return DateTime.TryParse( dateone, out DateTime dtone )
                && DateTime.TryParse( datetwo, out DateTime dttwo )
                    ? dtone.Diff( dttwo ).TotalDays
                    : 0;
        }

        /// <summary>
        /// Returns a double indicating the number of days between two dates (past is
        /// negative)
        /// </summary>
        /// <param name = "startDate" >
        /// The startDate one.
        /// </param>
        /// <param name = "endDate" >
        /// The startDate two.
        /// </param>
        /// <returns>
        /// </returns>
        public static double DiffDays( this DateTime startDate, DateTime endDate )
        {
            return startDate.Diff( endDate ).TotalDays;
        }

        /// <summary>
        /// Returns a double indicating the number of days between two dates (past is
        /// negative)
        /// </summary>
        /// <param name = "dateone" >
        /// The startDate one.
        /// </param>
        /// <param name = "datetwo" >
        /// The startDate two.
        /// </param>
        /// <returns>
        /// </returns>
        public static double DiffHours( this string dateone, string datetwo )
        {
            return DateTime.TryParse( dateone, out DateTime dtone )
                && DateTime.TryParse( datetwo, out DateTime dttwo )
                    ? dtone.Diff( dttwo ).TotalHours
                    : 0;
        }

        /// <summary>
        /// Returns a double indicating the number of days between two dates (past is
        /// negative)
        /// </summary>
        /// <param name = "startDate" >
        /// The startDate one.
        /// </param>
        /// <param name = "endDate" >
        /// The startDate two.
        /// </param>
        /// <returns>
        /// </returns>
        public static double DiffHours( this DateTime startDate, DateTime endDate )
        {
            return startDate.Diff( endDate ).TotalHours;
        }

        /// <summary>
        /// Returns a double indicating the number of days between two dates (past is
        /// negative)
        /// </summary>
        /// <param name = "dateone" >
        /// The startDate one.
        /// </param>
        /// <param name = "datetwo" >
        /// The startDate two.
        /// </param>
        /// <returns>
        /// </returns>
        public static double DiffMinutes( this string dateone, string datetwo )
        {
            return DateTime.TryParse( dateone, out DateTime dtone )
                && DateTime.TryParse( datetwo, out DateTime dttwo )
                    ? dtone.Diff( dttwo ).TotalMinutes
                    : 0;
        }

        /// <summary>
        /// Returns a double indicating the number of days between two dates (past is
        /// negative)
        /// </summary>
        /// <param name = "startDate" >
        /// The startDate one.
        /// </param>
        /// <param name = "endDate" >
        /// The startDate two.
        /// </param>
        /// <returns>
        /// </returns>
        public static double DiffMinutes( this DateTime startDate, DateTime endDate )
        {
            return startDate.Diff( endDate ).TotalMinutes;
        }

        /// <summary>
        /// The IsFederalHoliday
        /// </summary>
        /// <param name = "dateTime" >
        /// The startDate <see cref = "DateTime"/>
        /// </param>
        /// <returns>
        /// The <see cref = "bool"/>
        /// </returns>
        public static bool IsFederalHoliday( this DateTime dateTime )
        {
            // to ease typing
            int _nthDay = (int)Math.Ceiling( dateTime.Day / 7.0d );
            DayOfWeek _date = dateTime.DayOfWeek;
            bool _thursday = _date == DayOfWeek.Thursday;
            bool _friday = _date == DayOfWeek.Friday;
            bool _monday = _date == DayOfWeek.Monday;
            bool _weekend = _date == DayOfWeek.Saturday || _date == DayOfWeek.Sunday;

            switch( dateTime.Month )
            {
                // New Years Day (Jan 1, or preceding Friday/following Monday if weekend)
                case 12 when dateTime.Day == 31 && _friday:
                case 1 when dateTime.Day == 1 && !_weekend:
                case 1 when dateTime.Day == 2 && _monday:

                // MLK day (3rd monday in January)
                case 1 when _monday && _nthDay == 3:

                // President’s Day (3rd Monday in February)
                case 2 when _monday && _nthDay == 3:

                // MemorialDay Day (Last Monday in May)
                case 5 when _monday && dateTime.AddDays( 7 ).Month == 6:

                // IndependenceDay Day (July 4, or preceding Friday/following Monday if weekend)
                case 7 when dateTime.Day == 3 && _friday:
                case 7 when dateTime.Day == 4 && !_weekend:
                case 7 when dateTime.Day == 5 && _monday:

                // LaborDay Day (1st Monday in September)
                case 9 when _monday && _nthDay == 1:

                // ColumbusDay Day (2nd Monday in October)
                case 10 when _monday && _nthDay == 2:

                // Veteran’s Day (November 11, or preceding Friday/following Monday if weekend))
                case 11 when dateTime.Day == 10 && _friday:
                case 11 when dateTime.Day == 11 && !_weekend:
                case 11 when dateTime.Day == 12 && _monday:

                // ThanksgivingDay Day (4th Thursday in November)
                case 11 when _thursday && _nthDay == 4:

                // ChristmasDay Day (December 25, or preceding Friday/following Monday if weekend))
                case 12 when dateTime.Day == 24 && _friday:
                case 12 when dateTime.Day == 25 && !_weekend:
                case 12 when dateTime.Day == 26 && _monday:
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>Fails the specified ex.</summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}