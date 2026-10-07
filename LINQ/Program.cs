using Microsoft.Win32.SafeHandles;
using System.Security.Cryptography;
using static LINQ.ListGenerator;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators


            ////1. Find all products that are out of stock.
            //var result = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach(var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            ////2 Find all products that are in stock and cost more than 3.00 per unit.
            //var result1 = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var product in result1)
            //{
            //    Console.WriteLine(product);
            //}

            ////3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result2 = Arr.Where((d, index) => d.Length < index);

            //foreach (var digit in result2)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #region Element Operators


            //1.Get first Product out of Stock
            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock ==0);
            //Console.WriteLine( result);

            ////2 Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result1 =ProductsList.FirstOrDefault( p => p.UnitPrice > 1000);
            //Console.WriteLine( result1);

            ////3 Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result2 = Arr.Where(n => n > 5).ElementAtOrDefault(1);
            //Console.WriteLine(result2);
            #endregion

            #region  Aggregate Operators

            //// 1.Uses Count to get the number of odd numbers in the array
            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(result);

            //2 Return a list of customers and how many orders each has
            //var result1 = CustomersList.Select(c => new { c.CustomerID, c.CustomerName, ordercount = c.Orders.Count() });

            //foreach(var customer in result1)
            //{
            //    Console.WriteLine($"CustomerID: {customer.CustomerID}, CustomerName: {customer.CustomerName}, OrderCount: {customer.ordercount}");
            //}

            //3. Return a list of categories and how many products each has  (missed)
            //var result = ProductsList.Select (p => new  { p.Category , v =ProductsList.Count(pr => pr.Category == p.Category) });                             
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Category: {product.Category}, ProductCount: {product.v}");
            //}

            //4  Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result2 = Arr.Sum();
            //Console.WriteLine(result2);

            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //var result = arr.Sum(s => s.Length);
            //Console.WriteLine( result);

            ////6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            //var result1 = arr.Min(s => s.Length);
            //Console.WriteLine(result1);

            ////7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            //var result2 = arr.Max(s => s.Length);
            //Console.WriteLine(result2);

            ////8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result3 = arr.Average(s => s.Length);
            //Console.WriteLine(result3);


            #endregion

            #region Ordering Operators
            //1. Sort a list of products by name
            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array. (missed)
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result1 = Arr.OrderBy(s => s, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in result1)
            //{
            //    Console.WriteLine(word);
            //}

            //3. Sort a list of products by units in stock from highest to lowest.
            //var result2 = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in result2)
            //{
            //    Console.WriteLine(product);
            //}

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero" , "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result3 = Arr.OrderBy(a => a.Length)
            //                   .ThenBy(a => a);
            //foreach (var i in result3)
            //{
            //    Console.WriteLine(i);
            //}

            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array. (case-insensitive missed)
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result4 = Arr.OrderBy(a => a.Length)
            //                   .ThenBy(a => a, StringComparer.OrdinalIgnoreCase);
            //foreach (var i in result4)
            //{
            //    Console.WriteLine(i);
            //}

            // 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result5 = ProductsList.OrderBy(p => p.Category)
            //                          .ThenByDescending(p => p.UnitPrice);

            //foreach (var product in result5)
            //{
            //    Console.WriteLine(product);
            //}

            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //same as 5

            ////8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result6 = Arr.Where(a =>  a.Length > 1 && a[1] == 'i')
            //                .Reverse();
            //foreach (var i in result6)
            //{
            //    Console.WriteLine(i);
            //}




            #endregion

            #region Transformation Operators

            //1. Return a sequence of just the names of a list of products.
            //var result = ProductsList.Select(p => p.ProductName);
            //foreach(var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result1 = words.Select(w => new { Uppercase = w.ToUpper(), Lowercase = w.ToLower() });
            //foreach (var word in result1)
            //{
            //    Console.WriteLine($"Uppercase: {word.Uppercase}, Lowercase: {word.Lowercase}");
            //}

            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result2 = ProductsList.Select(p => new { p.ProductName, Price = p.UnitPrice });
            //foreach (var product in result2)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price}");
            //}

            //4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result3 = Arr.Select((a, index) => new { value = a, Index = index, Match = a == index });
            //Console.WriteLine( "Number : In-place?");
            //foreach (var item in result3)
            //{
            //    Console.WriteLine($"{item.value} : {item.Match}");
            //}

            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result4 = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };
            //Console.WriteLine( "Pairs where a < b:");
            //foreach (var pair in result4)
            //{
            //    Console.WriteLine($" {pair.a} is less than {pair.b}");
            //}

            //6. Select all orders where the order total is less than 500.00.
            //var result5 = from c in CustomersList
            //              from o in c.Orders
            //              where o != null && o.Total < 500.00M
            //              select o;

            //foreach (var item in result5)
            //{
            //    Console.WriteLine(item);
            //}

            //7. Select all orders where the order was made in 1998 or later.
            var result6 = from c in CustomersList
                          from o in c.Orders
                          where o != null && o.OrderDate.Year >= 1998
                          select o;

            foreach (var item in result6)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
