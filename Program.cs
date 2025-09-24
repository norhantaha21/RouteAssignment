using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            ////Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //int number;
            //bool isParsed;
            //while (true) {
            //Console.WriteLine("Enter a Number : ");
            //isParsed = int.TryParse(Console.ReadLine(), out number);
            //    if (isParsed)
            //    {
            //        if (number % 3 == 0 && number % 4 == 0)
            //        {
            //            Console.WriteLine("Yes");
            //        }
            //        else
            //            Console.WriteLine("No");
            //    }
            //    else
            //    {
            //        Console.WriteLine("invalid number ");

            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Question2
            //// Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //    Console.Write("Enter a number: ");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out int result);

            //    if (isParsed)
            //    {
            //        if (result < 0)
            //        {
            //            Console.WriteLine("The number is negative");
            //        }
            //        else if (result > 0)
            //        {
            //            Console.WriteLine("The number is positive");
            //        }
            //        else
            //        {
            //            Console.WriteLine("The number is zero");
            //        }

            //}
            //else
            //    {
            //        Console.WriteLine("Invalid number.");
            //    }
            #endregion
            #region Question3
            //// Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int num01, num02, num03;

            //while (true)
            //{
            //    Console.Write("Enter number 1: ");
            //    if (int.TryParse(Console.ReadLine(), out num01))
            //        break;
            //    Console.WriteLine("Invalid number, please try again.");
            //}

            //while (true)
            //{
            //    Console.Write("Enter number 2: ");
            //    if (int.TryParse(Console.ReadLine(), out num02))
            //        break;
            //    Console.WriteLine("Invalid number, please try again.");
            //}

            //while (true)
            //{
            //    Console.Write("Enter number 3: ");
            //    if (int.TryParse(Console.ReadLine(), out num03))
            //        break;
            //    Console.WriteLine("Invalid number, please try again.");
            //}

            //int max = Math.Max(num01, Math.Max(num02, num03));
            //int min = Math.Min(num01, Math.Min(num02, num03));

            //Console.WriteLine($"Maximum number is: {max}");
            //Console.WriteLine($"Minimum number is: {min}");

            #endregion
            #region Question4
            ////Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int number;

            //while (true) {
            //    Console.WriteLine("Enter a number ");
            //    if (int.TryParse(Console.ReadLine(), out  number)) {
            //        break;
            //    }
            //    Console.WriteLine("invalid , try again");
            //}
            //if (number == 0)                    //lazem nrtb elshroot mn el ma7dod ll aws3
            //     Console.WriteLine("zero");
            //else if (number % 2 == 0)
            //     Console.WriteLine("Even");
            //else
            //     Console.WriteLine("Odd");
            #endregion
            #region Question5
            ////- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Enter character : ");
            //string input = Console.ReadLine().ToLower();

            //if (input.Length == 1)
            //{
            //    char ch = input[0]; // awl 7arf bs 3shan fo2 m7dden eno string
            //    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //    {
            //        Console.WriteLine("Vowel");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Consonant");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid, enter single character !");
            //}
            #endregion
            #region Question6
            ////Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            //int number;
            //while (true) {
            //    Console.WriteLine("Enter a number : ");
            //    if (int.TryParse(Console.ReadLine(), out number))
            //        break;
            //    else
            //        Console.WriteLine("invalid ,try again !");
            //        }
            //for (int i = 1; i <=number; i++) {
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Question7
            ////Write a program that allows the user to insert an integer then print a multiplication table up to 12

            //int number;
            //Console.WriteLine("Enter a number : ");

            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out number))
            //        break;
            //    else
            //        Console.WriteLine("invalid , try again ! ");
            //}
            //for (int i = 0; i <= 12; i++)
            //{
            //    int result = number * i;
            //    Console.WriteLine(result);
            //}

            #endregion
            #region Question8
            ////Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter a number : ");
            //int number;

            //while (true) {
            //    if (int.TryParse(Console.ReadLine(), out number))
            //        break;
            //    else
            //        Console.WriteLine("invalid , try again !");
            //}
            //for (int i = 0; i < number; i+=2) {
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Question9
            ////Write a program that takes two integers then prints the power
            //Console.WriteLine("Enter a Number : ");
            //double number01 , number02;

            //while (true)
            //{
            //    if (double.TryParse(Console.ReadLine(), out number01))
            //        break;
            //    else
            //        Console.WriteLine("invalid , try again !");
            //}
            //while (true)
            //{
            //    if (double.TryParse(Console.ReadLine(), out number02))
            //        break;
            //    else
            //        Console.WriteLine("invalid , try again !");
            //}

            //double result = Math.Pow(number01 , number02);
            //Console.WriteLine( $"Result = {result}");
            #endregion
            #region Question10
            ////Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Enter marks of five subjects (0-100):");

            //int[] marks = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    while (true)
            //    {
            //        Console.Write($"Mark {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out int mark) && mark >= 0 && mark <= 100)
            //        {
            //            marks[i] = mark;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input, please enter a number between 0 and 100.");
            //        }
            //    }
            //}

            //double total = 0;
            //foreach (int m in marks)
            //    total += m;

            //double average = total / 5;
            //double percentage = (total / 500) * 100;

            //Console.WriteLine($"Total = {total}");
            //Console.WriteLine($"Average = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");
            #endregion
            #region Question11
            ////Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter the month number (1-12): ");
            //int num;

            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out num) && num >= 1 && num <= 12)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Enter a number between 1 and 12.");
            //}

            //int days = 0;

            //switch (num)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        days = 28;
            //        break;
            //}

            //Console.WriteLine($"Month {num} has {days} days.");



            #endregion
            #region Question12
            //// Write a program to create a Simple Calculator.
            //Console.WriteLine("Enter first number:");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number:");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter operator (+, -, *, /):");
            //string op = Console.ReadLine();
            //double result = 0;

            //switch (op)
            //{
            //    case "+": result = num1 + num2; 
            //        break;
            //    case "-": result = num1 - num2; 
            //        break;
            //    case "*": result = num1 * num2; 
            //        break;
            //    case "/": result = num2 != 0 ? num1 / num2 : 0; 
            //        break;
            //    default: Console.WriteLine("Invalid operator");
            //        break;
            //}
            //Console.WriteLine($"Result: {result}");
            #endregion

            #region Question13
            ////  Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter a string:");
            //string str = Console.ReadLine();
            //char[] arr = str.ToCharArray();
            //Array.Reverse(arr);
            //Console.WriteLine(new string(arr));
            #endregion

            #region Question14
            //// Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Enter an integer:");
            //int number = int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (number != 0)
            //{
            //    reversed = reversed * 10 + number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine($"Reversed number: {reversed}");
            #endregion

            #region Question15
            //// Find prime numbers within a range of numbers.
            //Console.WriteLine("Enter starting number:");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter ending number:");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Prime numbers between {start} and {end}:");
            //for (int i = start; i <= end; i++)
            //{
            //    if (i < 2) continue;
            //    bool isPrime = true;
            //    for (int j = 2; j * j <= i; j++)
            //    {
            //        if (i % j == 0) { isPrime = false; break; }
            //    }
            //    if (isPrime) Console.Write(i + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Question16
            //// 16- Convert a decimal number into binary without using an array
            //Console.WriteLine("Enter a number to convert to binary:");
            //int dec = int.Parse(Console.ReadLine());
            //string bin = "";
            //int temp = dec;
            //if (dec == 0) bin = "0";
            //while (temp > 0)
            //{
            //    bin = (temp % 2) + bin;
            //    temp /= 2;
            //}
            //Console.WriteLine($"Binary of {dec} is {bin}");
            #endregion

            #region Question17
            //// Determine whether three points lie on a single straight line
            //Console.WriteLine("Enter x1 y1:");
            //string[] p1 = Console.ReadLine().Split();
            //Console.WriteLine("Enter x2 y2:");
            //string[] p2 = Console.ReadLine().Split();
            //Console.WriteLine("Enter x3 y3:");
            //string[] p3 = Console.ReadLine().Split();

            //double x1 = double.Parse(p1[0]), y1 = double.Parse(p1[1]);
            //double x2 = double.Parse(p2[0]), y2 = double.Parse(p2[1]);
            //double x3 = double.Parse(p3[0]), y3 = double.Parse(p3[1]);

            //double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            //if (area == 0) Console.WriteLine("Points are colinear");
            //else Console.WriteLine("Points are not colinear");
            #endregion

            #region Question18
            //// 18- Worker efficiency based on hours
            //Console.WriteLine("Enter time taken by worker (hours):");
            //double hours = double.Parse(Console.ReadLine());

            //if (hours >= 2 && hours <= 3) 
            //    Console.WriteLine("Highly efficient");
            //else if (hours > 3 && hours <= 4) 
            //    Console.WriteLine("Increase speed");
            //else if (hours > 4 && hours <= 5) 
            //    Console.WriteLine("Provide training");
            //else if (hours > 5) 
            //    Console.WriteLine("Required to leave the company");
            //else 
            //    Console.WriteLine("Invalid time");
            #endregion

            #region Question19
            //// Print identity matrix of size n*n
            //Console.WriteLine("Enter size of identity matrix:");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write(i == j ? "1 " : "0 ");
            //    Console.WriteLine();
            //}
            #endregion

            #region Question20
            ////Find sum of all elements of an array
            //Console.WriteLine("Enter size of array:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size];
            //int sum = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //    sum += arr1[i];
            //}
            //Console.WriteLine($"Sum = {sum}");
            #endregion

            #region Question21
            //// Merge two arrays of the same size sorted in ascending order
            //Console.WriteLine("Enter size of arrays:");
            //int m = int.Parse(Console.ReadLine());
            //int[] a1 = new int[m];
            //int[] a2 = new int[m];
            //Console.WriteLine("Enter first array:");
            //for (int i = 0; i < m; i++)
            //    a1[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second array:");
            //for (int i = 0; i < m; i++) 
            //    a2[i] = int.Parse(Console.ReadLine());

            //int[] merged = new int[2 * m];
            //for (int i = 0; i < m; i++) {
            //    merged[i] = a1[i]; merged[i + m] = a2[i]; 
            //}
            //Array.Sort(merged);
            //Console.WriteLine("Merged array:");
            //foreach (var v in merged)
            //    Console.Write(v + " ");
            //Console.WriteLine();
            #endregion

           //Question 22 && 23 && 24 && 25 unsolved

            #region Question26
            ////  Reverse order of words in a string
            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(' ', words));
            #endregion

            #region Question27
            //// Print One Dimensional Array in Reverse Order
            //Console.WriteLine("Enter size of array:");
            //int sz = int.Parse(Console.ReadLine());
            //int[] arrRev = new int[sz];
            //for (int i = 0; i < sz; i++) arrRev[i] = int.Parse(Console.ReadLine());
            //Array.Reverse(arrRev);
            //Console.WriteLine("Reversed array:");
            //foreach (int val in arrRev) Console.Write(val + " ");
            //Console.WriteLine();
            #endregion

        }
    }
}