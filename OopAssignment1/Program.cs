using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Assignment1_OOP
{
    internal class Program
    {
        //part01
        #region Summary
        //// ---------------------------
        //// 🔹 1. Access Modifiers
        //// ---------------------------
        //class TypeA
        //{
        //    private int X;   // ✅ private → Accessible only inside this class
        //    internal int Y;  // ✅ internal → Accessible only within the same project/assembly
        //    public int Z;    // ✅ public → Accessible everywhere
        //}

        //// ---------------------------
        //// 🔹 2. Enum Definitions
        //// ---------------------------
        //enum Gender { Male, Female }
        //enum Grades { A, B, C, D, E }
        //enum Branch { Cairo = 10, Dokki = 20 }

        //// ---------------------------
        //// 🔹 3. Struct vs Class
        //// ---------------------------
        //struct Point
        //{
        //    public int X, Y;
        //    // Struct is VALUE type → stored in Stack
        //}

        //class Student
        //{
        //    public int Id;
        //    public string Name;
        //    public Gender Gender;
        //    public Branch Branch;
        //    public Grades Grades;
        //    // Class is REFERENCE type → stored in Heap
        //}

        //// ---------------------------
        //// 🔹 4. Permissions with Bitwise Enum
        //// ---------------------------
        //[Flags] // Allows combining multiple enum values
        //enum Permission
        //{
        //    None = 0,   // 0000
        //    Write = 1,  // 0001
        //    Read = 2,   // 0010
        //    Execute = 4,// 0100
        //    Delete = 8  // 1000
        //}

        //class User
        //{
        //    public int Id;
        //    public Permission Permissions;
        //}


        #endregion

        //part02
        #region Question1
        //internal enum WeekDays
        //{
        //    Monday, Tuesday
        //    , Wednesday,
        //    Thursday, Friday,
        //    Saturday, Sunday
        //}
        #endregion
        #region Question2
        // struct Person()
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //}
        #endregion
        #region Question3
        //enum Season
        //{
        //    Spring,
        //    Summer,
        //    Autumn,
        //    Winter
        //}
        #endregion
        #region Question4
        [Flags] 
        enum Permissions
        {
            None = 0,
            Read = 1,    
            Write = 2,    
            Delete = 4,   
            Execute = 8     
        }
        #endregion
            #region Question5
            //enum Colors
            //{
            //    Red,
            //    Green,
            //    Blue
            //}
            #endregion
            #region Question6
            //struct point
            //{
            //    public int x;
            //    public int y;
            //}

            //public static int Readint(string message)
            //{
            //    int value;
            //    while (true)
            //    {
            //        Console.WriteLine(message);
            //        if (int.TryParse(Console.ReadLine(), out value))
            //        {
            //            return value;
            //        }
            //        else
            //            Console.WriteLine("Invalid! , Enter Integer Number ");
            //    }
            //}
            #endregion
            #region Question7
            //struct Person
            //{
            //    public string Name;
            //    public int Age;
            //}

            #endregion

        static void Main(string[] args)
        {

            //part1
            #region MainSummary
            ////========================================================
            //// ⿡ ACCESS MODIFIERS
            //// ========================================================
            //TypeA typeA = new TypeA();
            //// typeA.X = 1; ❌ Error: private
            //// typeA.Y = 1; ✅ Accessible (internal)
            //// typeA.Z = 1; ✅ Accessible (public)

            //// ========================================================
            //// ⿢ ENUM USAGE
            //// ========================================================
            //Student std = new Student();
            //std.Id = 1;
            //std.Name = "Eman";
            //std.Gender = Gender.Female;  // ✅ Instead of writing "1"
            //std.Branch = Branch.Dokki;   // ✅ More readable than numbers
            //std.Grades = Grades.B;

            //Console.WriteLine($"Hello {std.Name}, Branch: {std.Branch}, Grade: {std.Grades}");

            //// Example: Parsing user input into Enum safely
            //Console.Write("Enter Grade: ");
            //bool isParsed = Enum.TryParse(Console.ReadLine(), out Grades gradeInput);
            //if (isParsed)
            //    Console.WriteLine($"You entered grade: {gradeInput}");
            //else
            //    Console.WriteLine("Invalid grade!");

            //// ========================================================
            //// ⿣ STRUCT vs CLASS
            //// ========================================================
            //Point p1 = new Point { X = 5, Y = 10 };
            //Console.WriteLine($"Point Struct → X:{p1.X}, Y:{p1.Y}");
            //// Struct stored in Stack → faster, lightweight

            //// Student (Class) stored in Heap → reference type
            //Student s1 = new Student { Id = 2, Name = "Ali", Gender = Gender.Male };
            //Console.WriteLine($"Student Class → {s1.Name} ({s1.Gender})");

            //// ========================================================
            //// ⿤ PERMISSIONS WITH BITWISE ENUM
            //// ========================================================
            //User user = new User();
            //user.Id = 10;

            //// Add permissions
            //user.Permissions = Permission.Write | Permission.Read;
            //Console.WriteLine($"User Permissions: {user.Permissions}"); // Write, Read

            //// Toggle (remove) Read
            //user.Permissions = user.Permissions ^ Permission.Read;
            //Console.WriteLine($"After removing Read: {user.Permissions}");

            //// Check if Execute exists
            //if ((user.Permissions & Permission.Execute) == Permission.Execute)
            //    Console.WriteLine("User has Execute");
            //else
            //    Console.WriteLine("User doesn’t have Execute");

            //// Add Execute
            //user.Permissions |= Permission.Execute;
            //Console.WriteLine($"Now Permissions: {user.Permissions}");

            #endregion

            #region MainQuestion1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays))) {
            //    Console.WriteLine(day);
            //}

            #endregion
            #region MainQuestion2
            //Person[] people = new Person[3];

            //people[0].Name = "Ali";
            //people[0].Age = 25;

            //people[1].Name = "Ola";
            //people[1].Age = 20;

            //people[2].Name = "Omar";
            //people[2].Age = 30;

            //Console.WriteLine("People details : ");
            //foreach (Person p in people) {
            //    Console.WriteLine($"Name: {p.Name} , Age : {p.Age}");          
            //}

            #endregion
            #region MainQuestion3
            //string seoson;
            //do
            //{
            //    Console.WriteLine("Enter a seoson : ");
            //    seoson = Console.ReadLine();
            //}
            //while (string.IsNullOrEmpty(seoson));

            //if (Enum.TryParse<Season>(seoson , true , out Season chosenseoson)) { 
            //    if(chosenseoson== Season.Spring)
            //        Console.WriteLine("Spring : March to May ");
            //    else if (chosenseoson == Season.Summer)
            //        Console.WriteLine("Summer : June to Augest ");
            //    else if (chosenseoson == Season.Autumn)
            //        Console.WriteLine("Autumn : September to November ");
            //    else if (chosenseoson == Season.Winter)
            //        Console.WriteLine("Winter : December to February ");
            //}
            //else
            //    Console.WriteLine("Invalid Seoson Entered");
            #endregion
            #region MainQuestion4
            //Permissions userPermissions = Permissions.None;

            //userPermissions |= Permissions.Read;    // Add Read
            //userPermissions |= Permissions.Write;   // Add Write

            //Console.WriteLine("Current Permissions: " + userPermissions);

            //userPermissions &= ~Permissions.Write;  // Remove Write
            //Console.WriteLine("After removing Write: " + userPermissions);
            //if (userPermissions.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("User has Read permission.");
            //}

            //if (!userPermissions.HasFlag(Permissions.Delete))
            //{
            //    Console.WriteLine("User does NOT have Delete permission.");
            //}

            //userPermissions |= (Permissions.Delete | Permissions.Execute);
            //Console.WriteLine("After adding Delete & Execute: " + userPermissions);
            #endregion
            #region MainQuestion5
            //string co;
            //do
            //{
            //    Console.WriteLine("Enter a Color");
            //    co = Console.ReadLine();
            //}
            //while (string.IsNullOrEmpty(co));

            //if (Enum.TryParse<Colors>(co ,true, out Colors color))
            //{
            //    Console.WriteLine($"{color} Is a Primary Color Primary");
            //}
            //else

            //    Console.WriteLine("Not Primary");



            #endregion
            #region MainQuestion6
            //point p1 = new point();
            //point p2 = new point();

            //p1.x = Readint("Enter X For Point 1 : ");
            //p1.y = Readint("Enter Y For Point 1 : ");

            //p2.x = Readint("Enter X For Point 2 : ");
            //p2.y = Readint("Enter Y For Point 2 : ");


            //double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            //Console.WriteLine($"Distance between points = {distance}");
            #endregion
            #region MainQuestion7
            //Person[] people = new Person[3];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"\n--- Person {i + 1} ---");

            //    Console.Write("Enter name: ");
            //    people[i].Name = Console.ReadLine();

            //    int age;
            //    while (true) 
            //    {
            //        Console.Write("Enter age: ");
            //        if (int.TryParse(Console.ReadLine(), out age))
            //        {
            //            people[i].Age = age;
            //            break; 
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid age. Please enter a valid number.");
            //        }
            //    }
            //}

            //Person oldest = people[0];
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //        oldest = people[i];
            //}

            //Console.WriteLine($"\nThe oldest person is {oldest.Name}, Age: {oldest.Age}");

            #endregion
        }
    }
   }
    
