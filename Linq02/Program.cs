using DemoG01.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using System.Transactions;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ElementOperators01
            ////Get first Product out of Stock 
            //var products = ListGenerator.ProductList.ToList();
            //var first = products.FirstOrDefault(p => p.UnitsInStock==0);
            //Console.WriteLine(first);

            #endregion

            #region ElementOperators0102
            //var products = ListGenerator.ProductList.ToList();
            //var check = products.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(check);
            #endregion

            #region ElementOperators03
            ////Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var check = Arr.Where(n=> n>5).ElementAtOrDefault(1);   // 1 => second element
            //Console.WriteLine(check);
            #endregion

            #region AggregateOperators01
            ////Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var odd = Arr.Count(o => o % 2 != 1);
            //Console.WriteLine(odd);
            #endregion

            #region AggregateOperators02
            ////return a list of customers and how many orders each has.
            //var customers = ListGenerator.CustomerList.Select(c => new
            //{
            //    c.CustomerName,
            //    orderCount = c.Orders.Count()

            //});
            //foreach (var customer in customers) {
            //    Console.WriteLine(customer);
            //}

            #endregion

            #region AggregateOperators03
            // //Return a list of categories and how many products each has
            // var categories = ListGenerator.ProductList
            //     .GroupBy(p => p.Category)
            //     .Select(g => new
            //     {
            //         Category = g.Key,
            //         proparoductCount = g.Count()
            //     });

            // foreach (var category in categories)
            // {
            //     Console.WriteLine($"{category.Category} : {category.proparoductCount}");
            //}
            #endregion

            #region AggregateOperators04
            //// Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = Arr.Sum();
            //Console.WriteLine(total);
            #endregion

            #region AggregateOperators05
            //string[] words = File.ReadAllLines(@"dictionary_english.txt");
            //int totalChars = words.Sum(w=> w.Length);
            //Console.WriteLine($"Total number of characters = {totalChars}");
            #endregion

            #region AggregateOperators06
            //string[] words = File.ReadAllLines(@"dictionary_english.txt");
            //int length = words.Min(x => x.Length);
            //Console.WriteLine(length);
            #endregion

            #region AggregateOperators07
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var longest = words.Max(w => w.Length);
            //Console.WriteLine(longest);
            #endregion

            #region AggregateOperators08
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var avg = words.Average(w => w.Length);
            //Console.WriteLine(avg);
            #endregion

            #region AggregateOperators09
            ////Get the total units in stock for each product category.    //VIP
            //var products = ListGenerator.ProductList.ToList();
            //var total = products.GroupBy(w => w.Category).Select(g => new
            //{
            //    category = g.Key,
            //    total = g.Sum(p => p.UnitsInStock)
            //});
            //foreach (var product in total) {
            //    Console.WriteLine($"{product.category} : {product.total}");
            //}
            #endregion

            #region AggregateOperators10
            ////Get the cheapest price among each category's products
            //var products = ListGenerator.ProductList.ToList();
            //var categories = products.GroupBy(x => x.Category).Select(g => new
            //{
            //    category = g.Key,
            //    MinPrice = g.Min(p => p.UnitPrice)
            //});
            //foreach (var category in categories) {
            //    Console.WriteLine($"{category.category} : {category.MinPrice}");
            //}
            #endregion

            #region AggregateOperators11
            ////Get the products with the cheapest price in each category (Use Let)
            //var products = ListGenerator.ProductList.ToList();
            //var categories = from p in products
            //                 group p by p.Category into g
            //                 let cheapest = g.Min(x => x.UnitPrice)
            //                 select new
            //                 {
            //                     category = g.Key,
            //                     product = g.Where(x => x.UnitPrice == cheapest)

            //                 };
            //foreach (var c in categories) {
            //    Console.WriteLine(c.category);
            //    foreach(var p in c.product) Console.WriteLine($"{p.ProductName} : {p.UnitPrice}");
            //}

            #endregion

            #region AggregateOperators12
            ////Get the most expensive price among each category's products.
            //var products = ListGenerator.ProductList.ToList();
            //var mostexp = products.GroupBy(x => x.Category).Select(y => new
            //{
            //    cat = y.Key,
            //    prod = y.Max(x => x.UnitPrice)
            //});
            //foreach (var product in mostexp) {
            //    Console.WriteLine($"{product.cat} : {product.prod}");

            //    }

            #endregion

            #region AggregateOperators13
            ////Get the products with the most expensive price in each category.
            //var products = ListGenerator.ProductList.ToList();
            //var mostexp = from p in products
            //              group p by p.Category into g
            //              let maxprice = g.Max(x => x.UnitPrice)
            //              select new
            //              {
            //                  category = g.Key,
            //                  pro = g.Where(x => x.UnitPrice == maxprice)
            //              };
            //foreach(var group in mostexp)
            //{
            //    Console.WriteLine(group.category);
            //    foreach(var p in group.pro)
            //    {
            //        Console.WriteLine($"{p.ProductName} : {p.UnitPrice}");
            //    }
            //}
            #endregion

            #region AggregateOperators14
            ////Get the average price of each category's products.
            //var products=ListGenerator.ProductList.ToList();
            //var avg = products.GroupBy(x => x.Category)
            //       .Select(z => new
            //       {
            //           category = z.Key,
            //           AvgPrice = z.Average(g => g.UnitPrice)
            //       });
            //foreach (var a in avg) {
            //    Console.WriteLine($"{a.category} : {a.AvgPrice}");
            //}

            #endregion

            #region SetOperators01
            ////Find the unique Category names from Product List
            // var products = ListGenerator.ProductList.ToList();
            //var unique = products.Select(x => x.Category)
            //   .Distinct();

            //foreach (var product in unique) {
            //    Console.WriteLine(product);
            // }

            #endregion

            #region SetOperators02
            //var products = ListGenerator.ProductList.ToList();
            //var customers = ListGenerator.CustomerList.ToList();

            //var prodFirstLetter = products.Select(p => p.ProductName[0]);
            //var custFirstLetter = customers.Select(x => x.CustomerName[0]);

            //var unique = prodFirstLetter.Union(custFirstLetter);
            //foreach (var c in unique) {
            //    Console.WriteLine(c);
            //}
            #endregion

            #region SetOperators03
            //var products = ListGenerator.ProductList.ToList();
            //var customers = ListGenerator.CustomerList.ToList();

            //var prodFirstLetter = products.Select(p => p.ProductName[0]);
            //var custFirstLetter = customers.Select(x => x.CustomerName[0]);

            //var common = prodFirstLetter.Intersect(custFirstLetter);
            //foreach (var c in common)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region SetOperators04
            //var products = ListGenerator.ProductList.ToList();
            //var customers = ListGenerator.CustomerList.ToList();

            //var prodFirstLetter = products.Select(p => p.ProductName[0]);
            //var custFirstLetter = customers.Select(x => x.CustomerName[0]);
            //var except = prodFirstLetter.Except(custFirstLetter);
            //foreach (var c in except)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region SetOperators05
            //var products = ListGenerator.ProductList.ToList();
            //var customers = ListGenerator.CustomerList.ToList();

            //var productLast3 =
            //    products
            //    .Select(p => p.ProductName.Length >= 3
            //                ? p.ProductName.Substring(p.ProductName.Length - 3)
            //                : p.ProductName);

            //var customerLast3 =
            //    customers
            //    .Select(c => c.CustomerName.Length >= 3
            //                ? c.CustomerName.Substring(c.CustomerName.Length - 3)
            //                : c.CustomerName);

            //var allLast3 =
            //    productLast3
            //    .Concat(customerLast3);   

            //foreach (var item in allLast3)
            //{
            //    Console.WriteLine(item);
            //}           
            #endregion

            #region PartitioningOperators01
            //// Get the first 3 orders from customers in Washington
            //var customers = ListGenerator.CustomerList.ToList();
            //var check = customers.Where(x => x.Region == "WA").SelectMany(x => x.Orders).Take(3);
            //foreach (var customer in check) {
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region PartitioningOperators02
            //// Get all but the first 2 orders from customers in Washington.
            //var customers = ListGenerator.CustomerList.ToList();
            //var check = customers.Where(x => x.Region=="WA").SelectMany(x => x.Orders).Skip(2);
            //foreach (var customer in check)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region PartitioningOperators03
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var check = numbers.TakeWhile((number, index) => number >= index);
            //foreach (var element in check)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region PartitioningOperators04
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var check = numbers.SkipWhile(n => n%3 !=0);
            //foreach (var element in check)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region PartitioningOperators05
            //int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //var check = numbers.SkipWhile((number, index) => number >= index);
            //foreach (var element in check)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            #region Quantifiers01
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var contain = words.Any(w=> w.Contains("ei"));
            //Console.WriteLine($"Any word contains 'ei'? {contain}");
            #endregion

            #region Quantifiers02
            //var products = ListGenerator.ProductList.ToList();
            //var check = from p in products
            //            group p by p.Category into g
            //            where g.Any(prod => prod.UnitsInStock==0)
            //            select g;

            //foreach (var p in check)
            //{
            //    Console.WriteLine(p.Key);
            //}

            #endregion

            #region Quantifiers03
            //var products = ListGenerator.ProductList.ToList();
            //var check = from p in products
            //             group p by p.Category into g
            //             where g.All(x=> x.UnitsInStock>0)
            //             select g;
            //foreach (var p in check)
            //{
            //    Console.WriteLine(p.Key);
            //}

            #endregion

            #region  GroupingOperators01
            ////Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var remainder = numbers.GroupBy(x => x % 5 == 0).OrderBy(x => x.Key);
            //foreach (var item in remainder)
            //{
            //    Console.WriteLine($"{item.Key} : {string.Join(" , ", item)}");
            //}
            #endregion

            #region GroupingOperators02
            ////Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var condition = words.GroupBy(w => w[0])
            //    .OrderBy(w => w.Key);

            //foreach (var c in condition)
            //    {
            //        Console.WriteLine(c.Key);
            //        foreach (var e in c) Console.WriteLine(e);
            //    }
            #endregion

            #region GroupingOperators03
            String[] Arr = {"from", "salt", "earn", " last", "near", "form"};
            var comparer = new EqualityComparer();
            var groups = Arr.Select(s => s.Trim()).GroupBy(w => w,comparer);

            int idx = 1;
            foreach (var group in groups) {
                Console.WriteLine($"Group {idx++} (key normalized): {string.Join(", ", group)}");
            }
            #endregion
        }
    }
}
