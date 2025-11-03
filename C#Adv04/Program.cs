using System.Collections;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace C_Adv04
{
    internal class Program
    {

        #region Question01
        //static Dictionary<int, int> CountFrequencies(int[] arr)
        //{
        //    var freq = new Dictionary<int, int>();
        //    foreach (var x in arr)
        //    {
        //        if (freq.ContainsKey(x))
        //            freq[x]++;
        //        else
        //            freq[x] = 1;
        //    }
        //    return freq;
        //}
        #endregion

        #region Question02
        //static string KeywithMaxValue(Dictionary<string, int> dict)
        //{
        //    if (dict == null || dict.Count == 0)
        //        return null;
        //    string maxkey = null;
        //    int maxVal = int.MinValue;
        //    foreach (var x in dict)
        //    {
        //        if (x.Value > maxVal)
        //        {
        //            maxkey = x.Key;
        //            maxVal = x.Value;
        //        }
        //    }
        //    return maxkey;
        //}

        #endregion

        #region Question03
            static List<string> KeysForValue(Dictionary<string, string> dict, string target)
            {
                var keys = new List<string>();
                foreach (var kv in dict)
                {
                    if (kv.Value == target)
                        keys.Add(kv.Key);
                }
                return keys;
            }
        #endregion

        #region Question04
        static List<List<string>> GroupAnagrams(string[] strs)
        {
            var map = new Dictionary<string, List<string>>();
            foreach (var s in strs)
            {
                var arr = s.ToCharArray();
                Array.Sort(arr);
                string key = new string(arr); // التوقيع
                if (!map.ContainsKey(key))
                    map[key] = new List<string>();
                map[key].Add(s);
            }
            var result = new List<List<string>>();
            foreach (var kv in map)
                result.Add(kv.Value);
            return result;
        }
            #endregion
            static void Main(string[] args)
        {
            #region MainQuestion01
            //int[] arr = { 1, 2, 2, 3, 1, 4, 2 };
            //var result = CountFrequencies(arr);
            //foreach (var x in result)
            //{
            //    Console.WriteLine($"{x.Key} -> {x.Value}");
            //}
            #endregion

            #region MainQuestion02
            //    var dict = new Dictionary<string, int>(){
            //    {"a", 10},
            //    {"b", 35},
            //    {"c", 20}
            //};

            //    var key = KeywithMaxValue(dict);
            //    if (key != null)
            //        Console.WriteLine($"Key with highest value: {key} (value = {dict[key]})");
            //    else
            //        Console.WriteLine("Dictionary is empty.");

            #endregion

            #region MainQuestion03
            //    var dict = new Dictionary<string, string>
            //{
            //    {"key1", "apple"},
            //    {"key2", "banana"},
            //    {"key3", "apple"}
            //};

            //    Console.Write("Enter target value: ");
            //    string target = Console.ReadLine()?.Trim();

            //    var keys = KeysForValue(dict, target);
            //    if (keys.Count == 0)
            //        Console.WriteLine("Key not found");
            //    else
            //        foreach (var k in keys)
            //            Console.WriteLine(k);

            #endregion

            #region MainQuestion04
            string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var groups = GroupAnagrams(input);
            foreach (var group in groups)
            {
                Console.WriteLine(string.Join(", ", group));
            }
            #endregion

            #region Question05
            int[] arr5 = { 1, 2, 3, 4, 2 };
            var seen = new HashSet<int>();
            bool hasDuplicates = false;
            foreach (var num in arr5)
            {
                if (!seen.Add(num))
                {
                    hasDuplicates = true;
                    break;
                }
            }
            Console.WriteLine("Question05 → Contains duplicates: " + hasDuplicates);
              #endregion


            #region Question06
            var students = new SortedDictionary<int, string>();
            students.Add(101, "Ali");
            students.Add(103, "Mona");
            students.Add(102, "Omar");

            students[104] = "Sara";

            students.Remove(103);

            
            Console.WriteLine("Question06 → Students List:");
            foreach (var kv in students)
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            #endregion


            #region Question07
            var employees = new SortedList<int, string>();
            employees.Add(5, "Ahmed");
            employees.Add(2, "Noha");
            employees.Add(9, "Hassan");

            Console.WriteLine("Question07 → Employee Directory:");
            foreach (var kv in employees)
                Console.WriteLine($"ID: {kv.Key}, Name: {kv.Value}");
            #endregion


            #region Question08
            int[] arr8 = { 1, 2, 4, 6, 7 };
            int N = 7;
            var missing = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                if (!arr8.Contains(i))
                    missing.Add(i);
            }
            Console.WriteLine("Question08 → Missing numbers: " + string.Join(", ", missing));
            #endregion


            #region Question09
            List<int> list9 = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            HashSet<int> uniqueSet = new HashSet<int>(list9);
            Console.WriteLine("Question09 → Unique values: " + string.Join(", ", uniqueSet));
            #endregion


            #region Question10
            var table10 = new Dictionary<string, string>
        {
            {"a", "apple"},
            {"b", "banana"},
            {"c", "cherry"}
        };
            var swapped = new Dictionary<string, string>();
            foreach (var kv in table10)
            {
                swapped[kv.Value] = kv.Key;
            }
            Console.WriteLine("Question10 → Swapped Dictionary:");
            foreach (var kv in swapped)
                Console.WriteLine($"{kv.Key} : {kv.Value}");
            #endregion


            #region Question11
            var setA = new HashSet<int> { 1, 2, 3 };
            var setB = new HashSet<int> { 3, 4, 5 };
            setA.UnionWith(setB);
            Console.WriteLine("Question11 → Union: " + string.Join(", ", setA));
            #endregion


            #region Question12
            var dict12 = new Dictionary<string, int>
        {
            {"apple", 1},
            {"animal", 2},
            {"airport", 3},
            {"banana", 4}
        };
            Console.Write("Question12 → Enter target char: ");
            char targetChar = Console.ReadLine()[0];
            int count = 0;
            foreach (var kv in dict12)
            {
                if (kv.Key.StartsWith(targetChar))
                    count++;
            }
            Console.WriteLine($"Keys starting with '{targetChar}' = {count}");
            #endregion


            #region Question13
            var sortedSet = new SortedSet<int> { 2, 4, 6, 8, 10 };
            Console.Write("Question13 → Enter target: ");
            int target13 = int.Parse(Console.ReadLine());
            var greaterList = new List<int>();
            foreach (var num in sortedSet)
            {
                if (num > target13)
                    greaterList.Add(num);
            }
            Console.WriteLine("Elements greater than target: " + string.Join(", ", greaterList));
            #endregion


            #region Question14
            var sortedList14 = new SortedList<int, int>
        {
            {1, 11},
            {2, 20},
            {3, 15},
            {4, 18},
            {5, 21}
        };
            var evenKeys = new List<int>();
            foreach (var kv in sortedList14)
            {
                if (kv.Value % 2 == 0)
                    evenKeys.Add(kv.Key);
            }
            Console.WriteLine("Question14 → Keys with even values: " + string.Join(", ", evenKeys));
            #endregion
        }
    }
}
