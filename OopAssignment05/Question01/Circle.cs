using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05_OOP.Question01
{
  
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * radius * radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape : Circle");
            Console.WriteLine($"Radius : {Radius}");
            Console.WriteLine($"Area : {Area:F2}");
        }

        public override string ToString()
        {
            return $"Radius : {Radius} , Area : {Area:F2}";
        }
    } 
    
}
