using System.Collections;

namespace C_Adv01
{
    internal class Program
    {

        #region Question02
        static void  reverse<T>(List<T> list)
        {
            int start = 0;
            int end = list.Count -1 ;

            while (start < end) {
               T temp= list[start];
                list[start] = list[end];
                list[end] = temp;
                start++;
                end--;
            }
        }
        #endregion

        #region Question03
        public static List<int> EvenArray(int[] arr)
        {
            List<int> evennum = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    evennum.Add(arr[i]);
            }
            return evennum;
        }
        #endregion

        #region Question05
        public static int nonrepeatedCharacter(string str)
        {
            Dictionary<char , int> freq = new Dictionary<char , int>();

            foreach (char c in str) { 
               if(freq.ContainsKey(c))
                    freq[c]++;
               else
                    freq[c] = 1;
            }

            for (int i =0;i<str.Length;i++)
            {
                if (freq[str[i]] ==1)
                    return i;
            }
            return -1;

        }
        #endregion
        static void Main(string[] args)
        {
            #region Main Question01
            //Range<int> intRange = new Range<int>(10, 20);
            //Console.WriteLine($"Is 15 in range? {intRange.IsRange(15)}");
            //Console.WriteLine($"Range length: {intRange.length()}");

            //Range<double> doubleRange = new Range<double>(1.5, 3.8);
            //Console.WriteLine($"Is 2.0 in range? {doubleRange.IsRange(2.0)}");
            //Console.WriteLine($"Range length: {doubleRange.length()}");     
            #endregion
            #region Main Question02
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //reverse(numbers);
            //Console.WriteLine(string.Join(", ", numbers));


            //List<string> names = new List<string> { "Ola", "Menna", "Nour" };
            //reverse(names);
            //Console.WriteLine(string.Join(", ", names));
            #endregion
            #region Main Question03
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //List<int> result = EvenArray(numbers);

            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Main Question04
            //FixedSizeList<string> names = new FixedSizeList<string>(3);

            //names.Add("Sara");
            //names.Add("Mona");
            //names.Add("Laila");

            //Console.WriteLine("Capacity: " + names.capacity);
            //Console.WriteLine("Count: " + names.Count);

            //Console.WriteLine("First element: " + names.Get(0)); 
            //Console.WriteLine("Second element: " + names.Get(1)); 
            //Console.WriteLine("Third element: " + names.Get(2)); 

            #endregion
            #region Main Question05
            //string word = "Bananna";
            //int index = nonrepeatedCharacter(word);

            //if (index != -1)
            //    Console.WriteLine($"First non-repeated character: '{word[index]}' at index {index}");
            //else
            //    Console.WriteLine("No non-repeated character found.");
            #endregion


        }
    }
}
