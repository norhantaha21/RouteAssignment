using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Adv01
{
    #region Question01
    internal class Range<T> where T : IComparable<T>
    {
        private T min;
        private T max;

        public Range(T min, T max)
        {
            this.min = min;
            this.max = max;
        }

        public bool IsRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        public double length()
        {
            return Convert.ToDouble(max) - Convert.ToDouble(min);
        }

    } 
    #endregion
}
