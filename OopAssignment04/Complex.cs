using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    internal class Complex
    {
        public double Real { get; set; }
        public double Imagine {  get; set; }

        public override string ToString()
        {
            String sign = (Imagine >= 0)? "+" : "-";
            return $"{Real} {sign} {Math.Abs(Imagine)}i";
        }

        
        public static Complex operator +(Complex left, Complex right) {
            return new Complex()
            {

                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imagine = (left?.Imagine ?? 0) + (right?.Imagine ?? 0)
            };

        }

        public static Complex operator -(Complex left, Complex right) {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imagine = (left?.Imagine ?? 0) - (right?.Imagine ?? 0)
            };
        }
        
    }
}
