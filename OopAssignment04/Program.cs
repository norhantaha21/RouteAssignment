namespace Assignment4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Main Question1
            //Calculator calc = new Calculator();
            //Console.WriteLine(calc.Add(5, 10));
            //Console.WriteLine(calc.Add(5, 10, 15));
            //Console.WriteLine(calc.Add(5.5, 2.3)); 
            #endregion
            #region Main Question2
            //Rectangle R01 = new Rectangle();
            //Rectangle R02 = new Rectangle(8 ,9);
            //Rectangle R03 = new Rectangle(5);

            //Console.WriteLine(R01);
            //Console.WriteLine(R02);
            //Console.WriteLine(R03);
            #endregion
            #region Main Question3
            //Complex c1= new Complex();
            //c1.Real = 10; c1.Imagine = 30;

            //Complex c2 = new Complex();
            //c2.Real = 5; c2.Imagine = 20;

            //Complex c3 = new Complex();
            //c3 = c1 + c2;

            //Complex c4 = new Complex();
            //c4 = c1 - c2;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            #endregion
            #region Main Question4
            //Employee employee = new Employee();
            //employee.Work();

            //Console.WriteLine();

            //Manager manager = new Manager();
            //manager.Work();
            #endregion
            #region Main Question5
            //BaseClass baseobj = new BaseClass();
            //// "baseObj" is a reference of type BaseClass
            //// and the actual object created with 'new' is also BaseClass.
            //// So both reference type and object type are BaseClass.

            //BaseClass obj1 = new DerivedClass1();
            ////  Reference type: BaseClass
            ////  Actual object type: DerivedClass1
            //// Because DisplayMessage() is overridden in DerivedClass1,
            //// C# will use *runtime binding* (dynamic binding).

            //BaseClass obj2 = new DerivedClass2();
            ////  Reference type: BaseClass
            ////  Actual object type: DerivedClass2
            //// The method in DerivedClass2 uses 'new', not 'override',
            //// which means it HIDES the base method instead of replacing it.
            //// So C# uses *compile-time binding* based on the reference type.

            //Console.WriteLine("--- Using BaseClass Reference ---");
            //baseobj.DisplayMessage();
            //// Output: "Message from BaseClass"
            ////  Reason:
            //// The method is called from the BaseClass itself.
            //// No override or hiding is involved, so the BaseClass version executes.

            //obj1.DisplayMessage();
            //// Output: "Message from DerivedClass1 (override)"
            ////  Reason:
            //// Even though the reference is BaseClass,
            //// the actual object in memory is DerivedClass1.
            //// Since the method was marked 'virtual' and 'override',
            //// C# binds to the derived version *at runtime* (polymorphism).

            //obj2.DisplayMessage();
            ////  Output: "Message from BaseClass"
            ////  Reason:
            //// Because the reference is of type BaseClass,
            //// and 'new' does not change the binding behavior.
            //// The compiler chooses the BaseClass version at compile time

            //Console.WriteLine("--- Using DerivedClass2 Reference ---");
            //DerivedClass2 d2 = new DerivedClass2();
            ////  Both reference and actual object are DerivedClass2,
            //// so now the hidden (new) version will be called.

            //d2.DisplayMessage();
            ////  Output: "Message from DerivedClass2 (new)"
            ////  Reason:
            //// Because both reference and object are of the same type (DerivedClass2),
            //// and that class hides the base method, its own version is executed.

            #endregion
            #region Main Part02
            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(7800); // 2h 10m 0s
            Duration D3 = new Duration(666);  // 0h 11m 6s

            Console.WriteLine($"D1 = {D1}");
            Console.WriteLine($"D2 = {D2}");
            Console.WriteLine($"D3 = {D3}");
            Console.WriteLine("----------------------------");

            D3 = D1 + D2;
            Console.WriteLine($"D3 = D1 + D2 → {D3}");

            D3 = D1 + 7800;
            Console.WriteLine($"D3 = D1 + 7800 → {D3}");

            D3 = 666 + D3;
            Console.WriteLine($"D3 = 666 + D3 → {D3}");

            D3 = ++D1;
            Console.WriteLine($"D3 = ++D1 → {D3}");

            D3 = --D2;
            Console.WriteLine($"D3 = --D2 → {D3}");

            D1 = D1 - D2;
            Console.WriteLine($"D1 = D1 - D2 → {D1}");

            Console.WriteLine($"D1 > D2 ? {D1 > D2}");
            Console.WriteLine($"D1 <= D2 ? {D1 <= D2}");

            if (D1)
                Console.WriteLine("D1 is True (greater than 0)");
            else
                Console.WriteLine("D1 is False (equal to 0)");

            DateTime obj = (DateTime)D1;
            Console.WriteLine($"Converted to DateTime → {obj}");


            #endregion
        }
    }
}
