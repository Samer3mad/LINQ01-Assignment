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
            var res = ProductList.Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3);

            var Res = from p in ProductList
                      where p.UnitsInStock == 0
                      select p;
            foreach (var item in Res)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
