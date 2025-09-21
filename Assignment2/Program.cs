namespace Assignment2
{
    internal class Program
    {
                #region Question1
                // Write a program that allows the user to enter a number then print it.

                //Console.Write("Enter a number: ");
                //int num = int.Parse(Console.ReadLine());
                //Console.WriteLine("You entered: " + num);

                #endregion

                #region Question2
                // Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

                //string str = "123abc";
                //try
                //{
                //    int val = int.Parse(str); 
                //    Console.WriteLine(val);
                //}
                //catch (FormatException)
                //{
                //    Console.WriteLine("FormatException: string contains non-numeric characters");
                //}

                #endregion

                #region Question3
                // Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
                /*
                float a = 10.5f;
                float b = 3.2f;
                float result = a / b;
                Console.WriteLine("Result: " + result); // Floating-point division result
                */
                #endregion

                #region Question4
                // Write C# program that Extract a substring from a given string.
                /*
                string text = "Hello World";
                string sub = text.Substring(0, 5);
                Console.WriteLine("Substring: " + sub);
                */
                #endregion

                #region Question5
                // Value type assignment
                /*
                int x = 10;
                int y = x;
                y = 20;
                Console.WriteLine("x = " + x); // Still 10
                Console.WriteLine("y = " + y); // 20
                */
                #endregion

                #region Question6
                // Reference type assignment
                /*
                int[] arr1 = { 1, 2, 3 };
                int[] arr2 = arr1;
                arr2[0] = 99;
                Console.WriteLine("arr1[0] = " + arr1[0]); // 99 because both point to same reference
                */
                #endregion

                #region Question7
                // Concatenate two strings
                /*
                string first = "Hello";
                string second = "World";
                string combined = first + " " + second;
                Console.WriteLine(combined);
                */
                #endregion

                #region Question8
                // Simple interest
                /*
                double principal = 1000, rate = 5, time = 2;
                double interest = (principal * rate * time) / 100;
                Console.WriteLine("Simple Interest = " + interest);
                */
                #endregion

                #region Question9
                // BMI calculation
                /*
                double weight = 70, height = 1.75;
                double bmi = weight / (height * height);
                Console.WriteLine("BMI = " + bmi);
                */
                #endregion

                #region Question10
                // Ternary operator temperature check
                /*
                int temp = 25;
                string result = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");
                Console.WriteLine(result);
                */
                #endregion

                #region Question11
                // Date in different formats
                /*
                Console.Write("Enter day: ");
                int d = int.Parse(Console.ReadLine());
                Console.Write("Enter month: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter year: ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine($"Today's date : {d} , {m} , {y}");
                Console.WriteLine($"Today's date : {d} / {m} / {y}");
                Console.WriteLine($"Today's date : {d} - {m} - {y}");
                */
                #endregion

                #region Question12
                // Output of DateTime formatting
                /*
                DateTime date = new DateTime(2024, 6, 14);
                Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
                // Correct output: The event is on 06/14/2024
                */
                #endregion

                #region Question13
                // Convert.ToInt32(!(30 < 20))
                /*
                int d = Convert.ToInt32(!(30 < 20));
                Console.WriteLine(d);
                // !(30<20) = !(false) = true -> Convert.ToInt32(true) = 1
                */
                #endregion

                #region Question14
                // Console.WriteLine(13 / 2 + " " + 13 % 2);
                /*
                Console.WriteLine(13 / 2 + " " + 13 % 2);
                // 13/2 = 6 (integer division), 13%2 = 1
                // Output: "6 1"
                */
                #endregion

                #region Question15
                // Complex increment/decrement
                /*
                int num = 1, z = 5;
                if (!(num <= 0))
                    Console.WriteLine(++num + z++ + " " + ++z);
                else
                    Console.WriteLine(--num + z-- + " " + --z);

                // Step by step:
                // num = 1 → !(1 <= 0) = true
                // ++num = 2
                // z++ = 5 (then z=6)
                // ++z = 7
                // => Output: "7 7"
                */
                #endregion
            }
        }
  