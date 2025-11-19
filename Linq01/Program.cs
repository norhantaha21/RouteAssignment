using DemoG01.Data;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;

namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region RestrictionOperators01
            //// Find all products that are out of stock.
            //var products = ListGenerator.ProductList.ToList();

            //var OutOfStock = from p in  products
            //                 where p.UnitsInStock ==0
            //                 select p;
            //Console.WriteLine("Products Out of Stock ");
            //foreach (var product in OutOfStock)
            //{
            //    Console.WriteLine($"{product.ProductName} - Units In Stock {product.UnitsInStock}");
            //}
            #endregion

            #region RestrictionOperators03
            ////Find all products that are in stock and cost more than 3.00 per unit.
            //var products = ListGenerator.ProductList.ToList();
            //var someProducts = from p in products
            //                   where p.UnitsInStock > 0 && p.UnitPrice > 3.00m
            //                   select p;

            //foreach (var product in someProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} : {product.UnitsInStock} unit in stock : {product.UnitPrice}$ for unit");
            //}

            #endregion

            #region RestrictionOperators03
            ////Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = from index in Enumerable.Range(0, Arr.Length)
            //             where Arr[index].Length < index
            //             select Arr[index];

            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}


            #endregion

            #region OrderingOperators01
            //// Sort a list of products by name
            ////-------method------------
            //var products=ListGenerator.ProductList.ToList();

            //var sorted = products.OrderBy(p => p.ProductName).ToList();

            //foreach (var p in sorted) {
            //    Console.WriteLine(p);

            ////-------------query -------------
            //var products = ListGenerator.ProductList.ToList();

            //var sorted = from product in products
            //             orderby product.ProductName
            //             select product;
            //foreach (var p in sorted)
            //{
            //    Console.WriteLine(p);

            // }


            #endregion

            #region OrderingOperators02
            ////Uses a custom comparer to do a case -insensitive sort of the words in an array.
            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //Array.Sort(Arr , StringComparer.OrdinalIgnoreCase);

            //foreach (var word in Arr) {
            //    Console.WriteLine(word);
            //}

            #endregion

            #region OrderingOperators03
            ////Sort a list of products by units in stock from highest to lowest
            //var products = ListGenerator.ProductList.ToList();

            //products.Sort((p1, p2) => p2.UnitsInStock.CompareTo(p1.UnitsInStock));

            //    foreach (var product in products) {
            //    Console.WriteLine($"{ product.ProductName} - { product.UnitsInStock}");
            //}
            #endregion

            #region OrderingOperators04

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //Array.Sort(Arr, (x, y) => { 
            //    int lengthCompare = x.Length.CompareTo(y.Length);
            //    if (lengthCompare != 0) 
            //        return lengthCompare;

            //    return x.CompareTo(y);
            //});
            //foreach (string str in Arr) {
            //    Console.WriteLine(str);
            //}
            #endregion

            #region OrderingOperators05
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr , (a,b) => { 
            //int compare = a.Length.CompareTo(b.Length);
            //if (compare != 0) return compare;
            //    return string.Compare(a, b, ignoreCase: true);      //OR  return string.Compare(a,b , StringComparison.OrdinalIgnoreCase);

            //});

            //foreach (String str in Arr)
            //{
            //    Console.WriteLine(str);
            //}

            ////---------------------------------------------
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorted =Arr .OrderBy(x => x.Length)
            //    .ThenBy(x => x , StringComparer.OrdinalIgnoreCase)
            //    .ToArray();
            //foreach (var x in sorted) {
            //    Console.WriteLine(x);
            //}
            #endregion

            #region OrderingOperators06
            ////Sort a list of products, first by category, and then by unit price, from highest to lowest.  //VIP
            //var products = ListGenerator.ProductList.ToList();

            //products.Sort((a, b) =>
            //{
            //    // Handle nulls for Category
            //    string catA = a.Category?.ToString() ?? "";
            //    string catB = b.Category?.ToString() ?? "";

            //    int compare = String.Compare(catA, catB, StringComparison.OrdinalIgnoreCase);
            //    if (compare != 0) return compare;

            //    // descending by UnitPrice
            //    return b.UnitPrice.CompareTo(a.UnitPrice);
            //});

            //foreach (var product in products) {
            //    Console.WriteLine(product);
            //}

            ////-------------------------------------------------------
            //var products = ListGenerator.ProductList.ToList();
            //var sorted = products
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice)
            //    .ToList();

            //foreach (var product in products)
            //{
            //        Console.WriteLine(product);
            //    }
            #endregion

            #region OrderingOperators07
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorted = Arr
            //    .OrderBy(w => w.Length)
            //    .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase)
            //    .ToArray();

            //foreach (var item in sorted) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region OrderingOperators08
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var sorted = Arr
            //    .Where(w => w.Length >= 2 && char.ToLower(w[1]) == 'i')
            //    .Reverse()
            //    .ToArray();
            //foreach (string str in sorted) {
            //    Console.WriteLine(str);
            //}
            #endregion

            #region TransformationOperators01
            //// Return a sequence of just the names of a list of products.
            //var products=ListGenerator.ProductList.ToList();

            //var productName = products.Select(p => p.ProductName);
            //foreach (var product in products) {
            //    Console.WriteLine(product);
            //}

            #endregion

            #region TransformationOperators02
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var soln = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });

            //foreach (var word in soln)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region TransformationOperators03
            //var products=ListGenerator.ProductList.ToList();

            //var properties = products.Select(x => new {Name = x.ProductName, ID = x.ProductID,Price =x.UnitPrice });
            //foreach (var property in properties) {
            //    Console.WriteLine(property);
            //}
            #endregion

            #region TransformationOperators04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var condition = Arr.Select((value, index) => new { index, value, IsMatch = value == index });

            //foreach (var item in condition) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region TransformationOperators05
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var condition = numbersA.SelectMany(a => numbersB.Where(b => a < b) , (a,b) => new {A=a , B=b});

            //Console.WriteLine("Method Syntax : ");
            //foreach (var x in condition) Console.WriteLine($" {x.A} is less than {x.B}");

            ////---------------------------Another Soln-----------------------------------------------
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var condition = from a in numbersA
            //                from b in numbersB
            //                where a < b
            //                select new { A=a , B=b};
            //Console.WriteLine("Query Syntax");
            //foreach (var x in condition) Console.WriteLine($" {x.A} is less than {x.B}");


            #endregion

            #region TransformationOperators06
            ////. Select all orders where the order total is less than 500.00.
            //var orders = new List<Order>
            //{
            //    new Order(1, new DateTime(1997,12,31), 450m),
            //    new Order(2, new DateTime(1998,5,21), 600m),
            //    new Order(3, new DateTime(2000,1,1), 300m)
            //};
            //var condition =orders.Where(o => o.Total<500m);
            //foreach (var order in condition) {
            //    Console.WriteLine(order);
            //}
            #endregion

            #region TransformationOperators07
            //Select all orders where the order was made in 1998 or later
            var orders = new List<Order>
            {
                new Order(1, new DateTime(1997,12,31), 450m),
                new Order(2, new DateTime(1998,5,21), 600m),
                new Order(3, new DateTime(2000,1,1), 300m)
            };
            var condition = orders.Where(d => d.OrderDate.Year >= 1998).ToList();
            foreach (var order in condition) {
                Console.WriteLine(order);
            }
            #endregion
        }
    }
}
