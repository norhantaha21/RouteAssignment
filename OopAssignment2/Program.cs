using System.Xml.Linq;

namespace Assignment2_OOP
{
    internal class Program
    {

        #region Question1
        // internal struct Person
        //{
        //    public string name;
        //    public int age;

        //    public override string ToString()
        //    {
        //        return $" Name: {name}, Age: {age}";
        //    }
        //}

        #endregion
        #region Question2
        //internal struct Point
        //{
        //    public double x;
        //    public double y;

        //    public override string ToString()
        //    {
        //        return $"X = {x} , Y = {y}";
        //    }

        //}

        #endregion
        #region Question3
        //  internal struct Person
        //{
        //    public string Name;
        //    public int Age;

        //    public override string ToString()
        //    {
        //        return $"Name : {Name} , Age : {Age}";
        //    }
        //}
        #endregion
        #region Question4
        //   internal struct Rectangle
        //{   
        //    //attributes
        //    private double width;
        //    private double height;

        //    //property
        //    public double Width
        //    {
        //        get { 
        //           return width;
        //        }
        //        set {
        //            if (value < 0) {
        //                Console.WriteLine("the value cann't be negative");
        //            }
        //            else
        //                width = value;
        //        } }
        //    public double Height {
        //        get { 
        //           return height;
        //        }
        //        set {
        //            if (value < 0) {
        //                Console.WriteLine("the value cann't be negative");
        //            }
        //            else
        //                height = value;
        //        }
        //    }

        //    //method
        //    public double Area
        //    {
        //        get
        //        {
        //            return width * height;
        //        }
        //    }
            

        //    public void DisplayInfo()
        //    {
        //        Console.WriteLine($"Height : {height}");
        //        Console.WriteLine($"Width : {width}");
        //        Console.WriteLine($"Area : {Area}");
        //    }
        //    public override string ToString()
        //    {
        //        return $"Width : {width} , Height : {height}";
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {
            #region MainQuestion1
            //Person[] people = new Person[3];
            //people[0].name = "Ola";
            //people[0].age = 22;

            //people[1].name = "Ali";
            //people[1].age = 26;

            //people[2].name = "Menna";
            //people[2].age = 31;

            //Console.WriteLine("=== Details of all persons ===");
            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person);   //by default btnady 3la to string 
            //}
            #endregion
            #region MainQuestion2
            //Console.WriteLine("=== Distance between two points ===");

            //Point[] points = new Point[2];
            //for (int i = 0; i < points.Length; i++) {
            //    Console.WriteLine($"Enter X for point {i+1}");
            //    points[i].x = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter Y for point {i + 1}");
            //    points[i].y = double.Parse(Console.ReadLine());

            //}

            //double distance = Math.Sqrt(
            //    Math.Pow(points[1].x - points[0].x, 2) +
            //    Math.Pow(points[1].y - points[0].y, 2)
            //    );

            //Console.WriteLine($"Point 1 : {points[0]}");
            //Console.WriteLine($"Point 2 : {points[1]}");
            //Console.WriteLine($"Distance between two points = {distance:F2}");

            #endregion
            #region MainQuestion3
            //Console.WriteLine("=== Details of the persons ===");
            //Person[] people = new Person[3];
            //for (int i = 0; i < people.Length; i++) {
            //    Console.WriteLine($"Name of person {i+1}");
            //    people[i].Name = Console.ReadLine();
            //    Console.WriteLine($"Age of person {i + 1}");
            //    people[i].Age=int.Parse( Console.ReadLine() );
            //}

            //Console.Clear();
            //Person oldest = people[0];
            //for (int i = 1; i < people.Length; i++) { 
            //  if (people[i].Age > oldest.Age)
            //    {
            //        oldest  = people[i];
            //    }
            //}

            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"{person}");
            //}
            //Console.WriteLine($"The oldest Person is {oldest}");
            #endregion
            #region MainQuestion4
            //Console.WriteLine("=== Rectangle info ===");
            //Rectangle rect = new Rectangle();
            //Console.WriteLine("Enter width ");
            //rect.Width= double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter height ");
            //rect.Height = double.Parse(Console.ReadLine());
            //Console.WriteLine("Rectangle details : ");
            //rect.DisplayInfo();
            //Console.WriteLine("Using ToString() :");
            //Console.WriteLine(rect);
            #endregion

        }
    }
}
