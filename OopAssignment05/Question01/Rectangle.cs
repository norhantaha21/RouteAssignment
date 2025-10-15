using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05_OOP.Question01
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }


        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Area = width * height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape : Rectangle");
            Console.WriteLine($"Width : {Width} , Height :{Height}");
            Console.WriteLine($"Area : {Area:F2}");
        }

        public override string ToString()
        {
            return $"Width : {Width} , Height :{Height} , Area : {Area:F2}";
        }
    } 

}
