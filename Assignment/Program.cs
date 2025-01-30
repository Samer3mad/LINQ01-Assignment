using System.Collections.Immutable;
using static Assignment.ListGenerator;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region Question 01
            //var res = ProductList.Where(P => P.UnitsInStock == 0);

            //var Res = from p in ProductList
            //      where p.UnitsInStock == 0
            //      select p;
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 02
            //var res = ProductList.Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3);
            //
            //var Res = from p in ProductList
            //          where p.UnitsInStock == 0
            //          select p;
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region Question 01
            //var Names = ProductList.OrderBy(p => p.ProductName).ToList();
            //
            //foreach (var product in Names)
            //    Console.WriteLine(product.ProductName);
            #endregion

            #region Question 03
            //var sorteDescending = ProductList.OrderByDescending(p => p.UnitsInStock);
            //
            //foreach (var product in sorteDescending)
            //    Console.WriteLine($"{product.ProductName}: {product.UnitsInStock} units");

            #endregion

            #region Question 06
            //var sorteProducts = ProductList.OrderBy(p => p.Category).OrderByDescending(p => p.UnitPrice);
            //
            //foreach (var product in sorteProducts)
            //    Console.WriteLine($"Product Category: {product.Category} ---------- Product Name: {product.ProductName} ---------- Product Price: {product.UnitPrice}");

            #endregion
            #endregion

            #region LINQ – Transformation Operators
            #region Question 01
            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //    Console.WriteLine(name);

            #endregion

            #region Question 03
            //var productDetails = ListGenerator.ProductList
            //         .Select(p => new
            //         {
            //             p.ProductName,
            //             Price = p.UnitPrice,
            //             p.UnitsInStock
            //         });
            //
            //foreach (var product in productDetails)
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.Price}, Stock: {product.UnitsInStock}");

            #endregion
            #endregion
        }
    }
}
