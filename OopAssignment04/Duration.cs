using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    #region Part02
    internal class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Duration(int totalsec)
        {
            hours = totalsec / 3600;
            int remainingsec = totalsec % 3600;

            minutes = remainingsec / 60;
            seconds = remainingsec % 60;

        }
        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public override string ToString()
        {
            return $" Hours: {hours}, Minutes : {minutes}, Seconds : {seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
            {
                return hours == other.hours && minutes == other.minutes && seconds == other.seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hours, minutes, seconds);
        }

        public static Duration operator +(Duration a, Duration b )
        {
            return new Duration( (a?.hours ?? 0) + (b?.hours ?? 0) ,
                 (a?.minutes ?? 0) + (b?.minutes ?? 0) ,
                (a?.seconds ?? 0) + (b?.seconds ?? 0)
                );
        }

        public static Duration operator + (int sec , Duration a)
        {
            return new Duration(
                (a?.hours ?? 0) * 3600
                + (a?.minutes ?? 0) * 60
                + (a?.seconds ?? 0) + sec
                );
        }

        public static Duration operator +(Duration a , int sec)
        {
            return new Duration(
                (a?.hours ?? 0) * 3600
                + (a?.minutes ?? 0) * 60
                + (a?.seconds ?? 0) + sec
                );
        }

        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration((a?.hours ?? 0) - (b?.hours ?? 0),
                 (a?.minutes ?? 0) - (b?.minutes ?? 0),
                (a?.seconds ?? 0) - (b?.seconds ?? 0)
                );
        }

        public static Duration operator ++(Duration a) {
            int totalSeconds = (a?.hours ?? 0) * 3600
               + (a?.minutes ?? 0) * 60
               + (a?.seconds ?? 0);
            totalSeconds += 60;
            return new Duration(totalSeconds);
        }

        public static Duration operator --(Duration a)
        {
            int totalSeconds = (a?.hours ?? 0) * 3600
               + (a?.minutes ?? 0) * 60
               + (a?.seconds ?? 0);
             totalSeconds -= 60;
            return new Duration ( totalSeconds );
        }

        public static bool operator >(Duration a, Duration b) { //lw m3mlnash < b3daha hnla2i error
            return ((a?.hours ?? 0) * 3600
                 + (a?.minutes ?? 0) * 120
                 + (a?.seconds ?? 0) > (b?.hours ?? 0) * 3600
                 + (b?.minutes ?? 0) * 120
                 + (b?.seconds ?? 0));
        }

        public static bool operator <(Duration a, Duration b)
        {
            return ((a?.hours ?? 0) * 3600
                 + (a?.minutes ?? 0) * 120
                 + (a?.seconds ?? 0) < (b?.hours ?? 0) * 3600
                 + (b?.minutes ?? 0) * 120
                 + (b?.seconds ?? 0));
        }

        public static bool operator <=(Duration a, Duration b)
        {
            return ((a?.hours ?? 0) * 3600
                 + (a?.minutes ?? 0) * 120
                 + (a?.seconds ?? 0) <= (b?.hours ?? 0) * 3600
                 + (b?.minutes ?? 0) * 120
                 + (b?.seconds ?? 0));
        }

        public static bool operator >=(Duration a, Duration b){ 
            return ((a?.hours ?? 0) * 3600
                 + (a?.minutes ?? 0) * 120
                 + (a?.seconds ?? 0) >= (b?.hours ?? 0) * 3600
                 + (b?.minutes ?? 0) * 120
                 + (b?.seconds ?? 0));
        }

        public static implicit operator bool(Duration a)    //VIP
        {
            return (a?.hours ?? 0) != 0 || (a?.minutes ?? 0) != 0 || (a?.seconds ?? 0) != 0;
        }

        public static explicit operator DateTime(Duration a)
        {
            try
            {
                return DateTime.Now
                    .AddHours(a?.hours ?? 0)
                    .AddMinutes(a?.minutes ?? 0)
                    .AddSeconds(a?.seconds ?? 0);
            }
            catch
            {
                return DateTime.Now;
            }
        }
    } 
    #endregion
}
