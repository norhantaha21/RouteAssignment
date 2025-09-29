using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Assignment4
{
    internal class Program
    {

        #region Question1

        //    /*
        // * Difference between Passing Value Type Parameters by Value and by Reference:
        // * 
        // * 1. Pass by Value:
        // *    - A copy of the variable’s value is passed to the method.
        // *    - Changes made inside the method do NOT affect the original variable.
        // * 
        // * 2. Pass by Reference:
        // *    - A reference (memory address) to the original variable is passed.
        // *    - Changes made inside the method DO affect the original variable.
        // *    - In C#, we use the "ref" or "out" keyword for passing by reference.
        // */

        //static void IncrementByValue(int number)    // Example of Pass by Value
        //{
        //    // Here "number" is just a copy of the original variable
        //    number = number + 10;
        //    // This change affects only the local copy because after increment in function stack frame will be removed and we dont have any copy for this new value
        //    Console.WriteLine("Inside IncrementByValue: " + number);
        //}

        //static void IncrementByReference(ref int number) // Example of Pass by Reference
        //{
        //    // Here "number" refers to the original variable
        //    number = number + 10; // This change affects the original variable because these refers on same ref
        //    Console.WriteLine("Inside IncrementByReference: " + number);
        //}

        #endregion
        #region Question2
        ///*
        //   * Difference between Passing Reference Type Parameters (like arrays) by Value and by Reference:
        //   * 
        //   * 1. Pass Reference Type by Value (default):
        //   *    - A copy of the reference (the memory address) is passed to the method.
        //   *    - You can modify the contents of the array, and changes will affect the original array.
        //   *    - BUT if you reassign the array to a new one inside the method,
        //   *      the original array outside the method will NOT be affected.
        //   * 
        //   * 2. Pass Reference Type by Reference (using "ref"):
        //   *    - The actual reference itself is passed to the method.
        //   *    - You can modify the array’s contents AND also reassign the array to a new one.
        //   *    - Reassignment will affect the original variable outside the method.
        //   */

        //static void ModifyByValue(int[] numbers)    // Pass Reference Type by Value
        //{
        //    numbers[0] = 99; // modifies original array
        //    numbers = new int[] { 7, 8, 9 }; // reassigns local copy only
        //}

        //static void ModifyByReference(ref int[] numbers)  // Pass Reference Type by Reference
        //{
        //    numbers[0] = 55; // modifies original array
        //    numbers = new int[] { 100, 200, 300 }; // reassigns and affects the original reference
        //}


        #endregion
        #region Question3
        //public void SumSub(double x, double y, out double sum, out double sub) {
        //    sum = x + y;
        //    sub = x - y;
        //}
        #endregion
        #region Question4
        //public int SumIndividualDigits(int number) {
        //    int sum = 0;

        //    while (number > 0) { 
        //       int digit = number % 10;
        //        sum += digit;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        #endregion
        #region Question5
        //public bool IsPrime(int num) {
        //   if (num <2)
        //        return false;
        //   for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //            return false ;
        //    }
        //        return true ;
        //}
        #endregion
        #region Question6
        //public void MaxMinArray(int[] array , ref int max , ref int min) {
        //    max = array.Max();
        //    min = array.Min();
        //}
        #endregion
        #region Question7
        //public int factorial(int num) {
        //    if (num == 0 || num ==1)
        //        return 1;
        //    else
        //        return num * (factorial(num - 1));

        //}
        #endregion
        #region Question8
        //  public string ChangeChar(string input,int index , char newChar)
        //{
        //    if (index < 0 || index > input.Length) {
        //        Console.WriteLine("Index is out of range");
        //    }
        //        StringBuilder sb = new StringBuilder(input);
        //         sb[index] = newChar;
        //         return sb.ToString();
        //} 
        #endregion
        #region Question9
        //public int SumOfArray(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        #endregion
        #region Question10
        //public int[] MergeAbdSort(int[] arr1, int[] arr2)
        //{
        //    int size = arr1.Length + arr2.Length;
        //    int[] merged = new int[size];

        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        merged[i] = arr1[i];
        //    }

        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        merged[arr1.Length+i] = arr2[i];
        //    }
        //    Array.Sort(merged);
        //    return merged;
        //}
        #endregion
        #region Question11
        //public void CountFrequency(int[] arr)
        //{
        //    Array.Sort(arr);  
        //    int count = 1;

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] == arr[i - 1])
        //        {
        //            count++; 
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Element {arr[i - 1]} occurred {count} times");
        //            count = 1; 
        //        }
        //    }

        //    Console.WriteLine($"Element {arr[arr.Length - 1]} occurred {count} times");  //m3mola l a5r element fe el array 3shan m4 htd5ol fe else 3shan mfesh rakm b3do tkaren m3ah
        //}

        #endregion
        #region Question12
        //   public void MaxMin(int[] arr , out int max , out int min) 
        //{
        //    max = arr.Max();
        //    min = arr.Min();
        //}
        #endregion
        #region Question13
        //  public int SecondLargestElement(int[] arr)
        //{
        //    Array.Sort(arr);
        //    return arr[arr.Length - 2]; ;
        //}
        #endregion
        

        static void Main(string[] args)
            {
            #region MainQuestion1
            //int x = 5;

            //Console.WriteLine("Original value of x: " + x);    //5

            //// Pass by Value
            //IncrementByValue(x);                        //15
            //// "x" remains unchanged because only a copy was modified
            //Console.WriteLine("After IncrementByValue, x = " + x); //5

            //// Pass by Reference
            //IncrementByReference(ref x);                   //15
            //// "x" is changed because the method modified the original variable
            //Console.WriteLine("After IncrementByReference, x = " + x); //15
            #endregion
            #region MainQuestion2
            //int[] arr1 = { 1, 2, 3 };

            //Console.WriteLine("Before ModifyByValue: " + string.Join(", ", arr1)); //1 2 3
            //ModifyByValue(arr1);
            //Console.WriteLine("After ModifyByValue: " + string.Join(", ", arr1));  //99 2 3
            //// Array contents changed, but reassignment did NOT affect the original

            //Console.WriteLine();

            //int[] arr2 = { 1, 2, 3 };

            //Console.WriteLine("Before ModifyByReference: " + string.Join(", ", arr2)); //1 2 3
            //ModifyByReference(ref arr2);
            //Console.WriteLine("After ModifyByReference: " + string.Join(", ", arr2));//100 200 300
            //// Both contents and reassignment affected the original

            #endregion
            #region MainQuestion3
            //Program p = new Program();

            //double a, b;
            //p.SumSub(30, 17, out a, out b);
            //Console.WriteLine($"Summation = {a}");
            //Console.WriteLine($"Subtraction = {b}");
            #endregion
            #region MainQuestion4
            //Console.WriteLine("Enter a number : ");

            //    if(int.TryParse(Console.ReadLine(), out int num)){

            //    Program p = new Program();
            //    int result = p.SumIndividualDigits(num);
            //    Console.WriteLine($"The sum of the digits of the number {num} is {result} ");
            //      }
            //    else
            //    Console.WriteLine("invalid");
            #endregion
            #region MainQuestion5
            //Console.WriteLine("Enter a number : ");

            //if (int.TryParse(Console.ReadLine(), out int num)) { 
            //   Program p = new Program();
            //   bool result = p.IsPrime(num);
            //    Console.WriteLine($"Is {num} a prime number ? {result}");
            //}
            //else
            //    Console.WriteLine("invalid");
            #endregion
            #region MainQuestion6
            //int[] numbers = { 5, 20, 3, 40, 22, 1 };
            //    int Maximum = 0, Minimum = 0;

            //Program p = new Program();
            //p.MaxMinArray(numbers, ref Maximum, ref Minimum);
            //Console.WriteLine($"Maximum: {Maximum}" );
            //Console.WriteLine($"Minimum: {Minimum}");
            #endregion
            #region MainQuestion7
            //Console.WriteLine("Enter a number ");
            //if (int.TryParse(Console.ReadLine(), out int num)) { 
            //    Program p = new Program();
            //    int result = p.factorial(num);
            //    Console.WriteLine($"Factorial of {num} is : {result}");
            //}
            #endregion
            #region MainQuestion8
            //  Program p = new Program();
            //Console.WriteLine("Enter a String : ");
            // string str = Console.ReadLine();

            //Console.WriteLine("Enter position (0-based index) :");
            //if (!int.TryParse(Console.ReadLine(), out int pos))
            //{
            //    Console.WriteLine("invalid position");
            //    return;
            //}

            //Console.WriteLine("Enter new character :");
            //string charinput = Console.ReadLine();

            //if (string.IsNullOrEmpty(charinput))
            //{
            //    Console.WriteLine("you must enter at leadt one character");
            //    return;
            //}

            //char ch = charinput[0];
            //string result =p.ChangeChar(str, pos , ch);
            //Console.WriteLine($"Modified string :  {result}");
            #endregion
            #region MainQuestion9
            //Program p = new Program();
            //int[] numbers = { 5, 10, 15, 20 };
            //int result = p.SumOfArray(numbers);
            //Console.WriteLine($"The Sum Of Array Elements is {result}");

            #endregion
            #region MainQuestion10
            //int[] arr1 = { 5, 2, 9 };
            //int[] arr2 = { 1, 7, 3 };

            //  Program p = new Program();
            //  int[] Merged = p.MergeAbdSort(arr1, arr2);
            //Console.WriteLine($"Merged and Sorted Array : {string.Join(" , " , Merged)}");
            #endregion
            #region MainQuestion11
            //int[] numbers = { 1, 2, 2, 3, 4, 1, 5, 2, 3 };
            //Program p = new Program();
            //p.CountFrequency(numbers);

            #endregion
            #region MainQuestion12
            //int[] arr = { 45 , 6 , 47, 2 , 9, 17};
            //   Program p = new Program();
            //int maximum = 0;
            //int minimum = 0;
            // p.MaxMin(arr, out maximum, out minimum);
            //Console.WriteLine($"The Maximum Nmber is : {maximum}");
            //Console.WriteLine($"The Minimum Nmber is : {minimum}");
            #endregion
            #region MainQuestion13
            //int[] numbers = { 5, 3, 9, 1, 7 };
            //Program p = new Program();
            //int secondmax = p.SecondLargestElement(numbers);
            //Console.WriteLine($"Second Largest element : {secondmax}");
            #endregion
            #region Question14
            //Console.WriteLine("Enter a size of Array :");           //VIP
            //string size = Console.ReadLine();
            //int n;

            //while(!int.TryParse(size,out n) || n<=0)
            //{
            //    Console.Write("Invalid input! Please enter a positive integer: ");
            //    size = Console.ReadLine();

            //}
            //int[] arr = new int[n];

            //Console.WriteLine("Enter array elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    string elementInput = Console.ReadLine();
            //    int value;

            //    while (!int.TryParse(elementInput, out value))
            //    {
            //        Console.Write("Invalid number! Please enter an integer: ");
            //        elementInput = Console.ReadLine();
            //    }

            //    arr[i] = value;
            //}

            //int maxDistance = -1;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n - 1; j > i; j--) 
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 2;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //            break; 
            //        }
            //    }
            //}
            //if (maxDistance == -1)
            //    Console.WriteLine("No equal elements found!");
            //else
            //    Console.WriteLine("Longest distance = " + maxDistance);

            #endregion
            #region Question15
            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();

            //string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //Array.Reverse(words);

            //string reversedSentence = string.Join(" ", words);

            //Console.WriteLine("Reversed sentence: " + reversedSentence);

            #endregion
            #region Question16
            //int rows, cols;       //VIP

            //while (true)
            //{
            //    Console.Write("Enter number of rows: ");
            //    if (int.TryParse(Console.ReadLine(), out rows) && rows > 0)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            //while (true)
            //{
            //    Console.Write("Enter number of columns: ");
            //    if (int.TryParse(Console.ReadLine(), out cols) && cols > 0)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //Console.WriteLine("Enter elements for the first array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        int value;
            //        while (true)
            //        {
            //            Console.Write($"Element [{i}][{j}]: ");
            //            if (int.TryParse(Console.ReadLine(), out value))
            //                break;
            //            else
            //                Console.WriteLine("Invalid input. Please enter an integer.");
            //        }
            //        firstArray[i, j] = value;
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //Console.WriteLine("Elements of the second array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Data copied successfully. Program completed.");
            #endregion
            #region Question17
            //int size;
            //while (true)
            //{
            //    Console.Write("Enter the size of the array: ");
            //    if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            //int[] array = new int[size];

            //Console.WriteLine("Enter elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    while (true)
            //    {
            //        Console.Write($"Element [{i}]: ");
            //        if (int.TryParse(Console.ReadLine(), out array[i]))
            //            break;
            //        else
            //            Console.WriteLine("Invalid input. Please enter an integer.");
            //    }
            //}

            //Console.WriteLine("Array in reverse order:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine("\n Done. Array printed in reverse order.");
            #endregion

        }
    }
    }

