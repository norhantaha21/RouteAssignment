using System.Collections;

namespace C_Adv02
{
    internal class Program
    {

        #region Question01
        static void bubble(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
        #endregion

        #region Question02
        public static void ReverseArrayList<T>(List<T> list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                T temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }

        }


        #endregion
        static void Main(string[] args)
        {
            #region Main Question01
            //int[] arr = { 5, 3, 1, 4, 2 };
            //bubble(arr);
            //Console.WriteLine("\nAfter sorting:");
            //foreach (int n in arr)
            //    Console.Write(n + " ");

            #endregion

            #region Main Question02
            //    List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //    Console.WriteLine("Before reversing:");
            //    foreach (int n in list)
            //        Console.Write(n + " ");

            //    ReverseArrayList(list);

            //    Console.WriteLine("\nAfter reversing:");
            //    foreach (int n in list)
            //        Console.Write(n + " ");
            //}
            #endregion

                #region Question03
                int[] arr = { 11, 5, 3 };
                int[] queries = { 1, 5, 13 };
                int count = 0;

                foreach (int x in queries)
                {

                    foreach (int num in arr)
                    {
                        if (num > x)
                            count++;
                    }
                    Console.WriteLine(count);
                }
                #endregion

                #region Question04
                //// Check if array is palindrome
                //int[] nums = { 1, 3, 2, 3, 1 };
                //bool isPalindrome = true;
                //for (int i = 0; i < nums.Length / 2; i++)
                //{
                //    if (nums[i] != nums[nums.Length - 1 - i])
                //    {
                //        isPalindrome = false;
                //        break;
                //    }
                //}
                //Console.WriteLine(isPalindrome ? "YES" : "NO");
                #endregion

                #region Question05
                //Queue<int> q = new Queue<int>();
                //q.Enqueue(1);
                //q.Enqueue(2);
                //q.Enqueue(3);
                //q.Enqueue(4);

                //Stack<int> s = new Stack<int>();
                //while (q.Count > 0)
                //    s.Push(q.Dequeue());
                //while (s.Count > 0)
                //    q.Enqueue(s.Pop());

                //Console.WriteLine("Reversed queue: " + string.Join(", ", q));
                #endregion

                #region Question06
                //string input = "[()]{ }";
                //Stack<char> stack = new Stack<char>();
                //bool balanced = true;

                //foreach (char c in input)
                //{
                //    if (c == '(' || c == '[' || c == '{')
                //        stack.Push(c);
                //    else if (c == ')' || c == ']' || c == '}')
                //    {
                //        if (stack.Count == 0)
                //        {
                //            balanced = false;
                //            break;
                //        }

                //        char top = stack.Pop();
                //        if ((c == ')' && top != '(') ||
                //            (c == ']' && top != '[') ||
                //            (c == '}' && top != '{'))
                //        {
                //            balanced = false;
                //            break;
                //        }
                //    }
                //}

                //if (balanced && stack.Count == 0)
                //    Console.WriteLine("Balanced");
                //else
                //    Console.WriteLine("Not Balanced");
                #endregion

                #region Question07
                //int[] array = { 1, 2, 2, 3, 3, 4, 5, 5 };
                //int[] unique = array.Distinct().ToArray();
                //Console.WriteLine("After removing duplicates: " + string.Join(", ", unique));
                #endregion

                #region Question08
                //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6 };
                //for (int i = list.Count - 1; i >= 0; i--)
                //{
                //    if ((int)list[i] % 2 != 0)
                //        list.RemoveAt(i);
                //}
                //Console.WriteLine("After removing odd numbers: " + string.Join(", ", list.ToArray()));
                #endregion

                #region Question09
                //Queue mixedQueue = new Queue();
                //mixedQueue.Enqueue(1);
                //mixedQueue.Enqueue("Apple");
                //mixedQueue.Enqueue(5.28);
                //Console.WriteLine("Mixed queue elements:");
                //foreach (var item in mixedQueue)
                //    Console.WriteLine(item);
                #endregion

                #region Question10
                //Stack<int> numStack = new Stack<int>();
                //numStack.Push(10);
                //numStack.Push(20);
                //numStack.Push(30);
                //numStack.Push(40);
                //numStack.Push(50);

                //Console.Write("Enter target: ");
                //int target = int.Parse(Console.ReadLine());
                //int count = 0;
                //bool found = false;

                //foreach (int n in numStack)
                //{
                //    count++;
                //    if (n == target)
                //    {
                //        Console.WriteLine($"Target was found successfully and the count = {count}");
                //        found = true;
                //        break;
                //    }
                //}
                //if (!found)
                //    Console.WriteLine("Target was not found");
                #endregion

                #region Question11
                //int[] arr1 = { 1, 2, 3, 4, 4 };
                //int[] arr2 = { 10, 4, 4 };

                //List<int> result = new List<int>();
                //Dictionary<int, int> freq = new Dictionary<int, int>();

                //foreach (int n in arr1)
                //{
                //    if (!freq.ContainsKey(n))
                //        freq[n] = 0;
                //    freq[n]++;
                //}

                //foreach (int n in arr2)
                //{
                //    if (freq.ContainsKey(n) && freq[n] > 0)
                //    {
                //        result.Add(n);
                //        freq[n]--;
                //    }
                //}

                //Console.WriteLine("Intersection: [" + string.Join(", ", result) + "]");
                #endregion

                #region Question12
                //List<int> numsList = new List<int>() { 1, 2, 3, 7, 5 };
                //int targetSum = 12;
                //bool foundSublist = false;

                //for (int i = 0; i < numsList.Count; i++)
                //{
                //    int sum = 0;
                //    List<int> temp = new List<int>();
                //    for (int j = i; j < numsList.Count; j++)
                //    {
                //        sum += numsList[j];
                //        temp.Add(numsList[j]);
                //        if (sum == targetSum)
                //        {
                //            Console.WriteLine("Sublist: [" + string.Join(", ", temp) + "]");
                //            foundSublist = true;
                //            break;
                //        }
                //    }
                //    if (foundSublist)
                //        break;
                //}

                //if (!foundSublist)
                //    Console.WriteLine("No sublist found.");
                #endregion

                #region Question13
                //Queue<int> q13 = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
                //int K = 3;

                //Stack<int> stack13 = new Stack<int>();
                //for (int i = 0; i < K; i++)
                //    stack13.Push(q13.Dequeue());

                //Queue<int> newQueue = new Queue<int>();
                //while (stack13.Count > 0)
                //    newQueue.Enqueue(stack13.Pop());

                //while (q13.Count > 0)
                //    newQueue.Enqueue(q13.Dequeue());

                //Console.WriteLine("Queue after reversing first K elements: [" + string.Join(", ", newQueue) + "]");
                #endregion


            }
        }
    }
