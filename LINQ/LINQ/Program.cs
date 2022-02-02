using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productsList = Helper.GetList();

            // the where should be before the select, because you are reducing the number of records you are selecting from
            var debug = productsList.Where(r => r.ListPrice > 10).Select(r => r.ListPrice);
            debug = productsList.Select(r => r.ListPrice).Where(r => r > 10);

            // if you want to select multiple columns, you will select it to anonymous object
            var debug2 = productsList.Select(r => new { r.Name, r.Color });

            // order, the last one win
            var debug3 = productsList.OrderBy(r => r.Name).OrderByDescending(r => r.Name);

            var debug4 = productsList.OrderBy(r => r.ListPrice).ThenByDescending(r => r.Name).ToList();

            try
            {
                // in First, Last, Single, SingleOrDefault an exception will happen if there is no or more than one result
                // but in FirstOrDefalut, LastOrDefault if there are no data it will return null
                var debug5 = productsList.FirstOrDefault(r => r.Name == "abc");
                productsList.First(r => r.Name == "abc");

                // SingleOrDefault will throw exception if there are more than one result, but if no result it will not throw exception
                var debug6 = productsList.SingleOrDefault(r => r.ListPrice == 49.99M);

                // Single must return exactly one value, so use single only when you are searching for a unique key
                productsList.Single(r => r.Name == "HL Road Frame - Black, 58");

                // Last and LastOrDefault are exactly like First and FirstOrDefault 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            //--------------------------------------------------------------------------
            productsList.ForEach(r => r.NameLength = r.Name.Length);
            productsList.ForEach(r => r.TotalSales = (productsList.Where(e => e.ProductID == r.ProductID).Sum(e => e.ListPrice) + 5));

            var debug7 = productsList.OrderBy(r => r.Name).Skip(2).Take(5).ToList();

            // difference between takeWhile and where => take while stops when the condition is not met
            // so here in this example it will take the first 5 elements only because the first 5 elements match the condition 
            // but the next one is not, so the take while will not look at the rest of the list
            var debug8 = productsList.TakeWhile(r => r.Name.StartsWith('H')).ToList();

            // the where loop through all the list
            var debug9 = productsList.Where(r => r.Name.StartsWith('H')).ToList();

            // skip while is the same
            var debug10 = productsList.SkipWhile(r => r.Name.StartsWith('H')).ToList();

            var debug11 = productsList.Select(r => r.ListPrice).Distinct().ToList();

            // distinct based on one field only
            var debug12 = productsList.GroupBy(r => r.ListPrice).Select(r => r.FirstOrDefault()).ToList();
            //--------------------------------------------------------------------------
            // return true if all items match that condition
            var debug13 = productsList.All(r => r.Name.Contains(' '));

            // return true if at least one (any one) in the list match the condition
            var debug14 = productsList.Any(r => r.Name.StartsWith('A'));

            // return true if that value exists in the list, it's different from string.contains
            // for simple data types (int, string...) we can simply use it, but otherwise we have to use an Equality Comparer class 
            // because by default it compares the object reference
            var intList = new List<int> { 1, 2, 3 };
            var debug15 = intList.Contains(1);
            var debug16 = productsList.Contains(new Product { Name = "HL Road Frame - Black, 58" }, new ProductNameComparer());

            // sequence equal is a LINQ operator that we can use to compare two collections for equality
            // when we use simple data types (int, string,...) we check values, and with object data types we use Equality comparer
            // sequence equal return true only if the two lists are identically matched
            var intList2 = new List<int> { 1, 2, 3 };
            var debug17 = intList.SequenceEqual(intList2);

            var productList1 = new List<Product> { new Product { Name = "HL Road Frame - Black, 58" } };
            var productList2 = new List<Product> { new Product { Name = "HL Road Frame - Black, 58" } };

            var debug18 = productList1.SequenceEqual(productList2, new ProductNameComparer());
            //--------------------------------------------------------------------------
            // except finds values in one list but not the other
            // and the same thing for the reference object lists, you have to use Equality comparer
            var intList3 = new List<int> { 1, 2, 3, 4, 5 };
            var debug19 = intList3.Except(intList2);

            // intersect finds all values in common between two lists
            // and the same thing for the reference object lists, you have to use Equality comparer
            var debug20 = intList3.Intersect(intList2);

            // there are two methods that are used to gather content of two lists (concat, union)
            // and the difference between the two of them is that Union is smarter, it removes the redundant
            // but concat just get the values of the two lists without thinking
            // and the same thing for the reference object lists, you have to use Equality comparer

            var debug21 = intList3.Concat(intList2);
            var debug22 = intList3.Union(intList2);
            //------------------------------inner join--------------------------------------------
            // equi joing is like the inner join in sql
            var smallList1 = Helper.GetSmallList1();
            var smallList2 = Helper.GetSmallList2();

            var innerJoin = (from x in smallList1
                             join y in smallList2
                             on x.ProductID equals y.ProductID
                             select new { x.ProductID, x.Name, y.Size }).ToList();
            var innerJoinMethodSyntax = smallList1.Join(smallList2,
                x => x.ProductID,
                y => y.ProductID,
                (x, y) => new
                {
                    x.ProductID,
                    x.Name,
                    y.Size
                }).ToList();

            var innerJoinMultKeys = (from x in smallList1
                                     join y in smallList2
                                     on new { x.ProductID, x.ListPrice } equals new { y.ProductID, y.ListPrice }
                                     select new
                                     {
                                         x.ProductID,
                                         x.Name,
                                         y.TotalSales
                                     }).ToList();

            var innerJoinMultiKeysMethodSyntax = smallList1.Join(smallList2,
                x => new { x.ProductID, x.ListPrice },
                y => new { y.ProductID, y.ListPrice },
                (x, y) => new
                {
                    x.ProductID,
                    x.Name,
                    y.Size
                }).ToList();
            //------------------------------------one to many--------------------------------------
            // in Entity framework, you can include the nested object that has one-to-many relationship, to do this in linq it's called group join
            // The group join is useful for producing hierarchical data structures.
            // It pairs each element from the first collection with a set of correlated elements from the second collection.
            var salesList = Helper.GetAllSalesOrderDetails().ToList();

            IEnumerable<ProductSales> productSales = (from prod in productsList
                                                      join sale in salesList
                                                      on prod.ProductID equals sale.ProductID
                                                      // we are taking the result of the join and puting it into a new variable called sales
                                                      into sales
                                                      select new ProductSales
                                                      {
                                                          Product = prod,
                                                          Sales = sales
                                                      });
            IEnumerable<ProductSales> productSalesMethodSyntax = productsList.GroupJoin(salesList,
                prod => prod.ProductID,
                sale => sale.ProductID,
                // please note that sales is a new variable, so it's internally making the join and give it to the select
                (prod, sales) => new ProductSales
                {
                    Product = prod,
                    Sales = sales.ToList()
                });
            //-----------------------------Left outer join---------------------------------------------
            // Technically, there in nothing called left outer join in linq, but we can simulate one
            // the left join gets the whole left list, and if the right list doesn't have data, it will be null (DefaultIfEmpty)
            var leftJoinProductsToSales = (from prod in productsList
                                           join sale in salesList
                                            on prod.ProductID equals sale.ProductID
                                           into sales
                                           // and we are going to select from the result of that goin
                                           from sale in sales.DefaultIfEmpty()
                                           select new
                                           {
                                               ProductID = prod.ProductID,
                                               Name = prod.Name,
                                               OrderQty = sale?.OrderQty,
                                               UnitPrice = sale?.UnitPrice
                                           }).ToList();

            var leftJoinSalesToProducts = (from sale in salesList
                                           join prod in productsList
                                            on sale.ProductID equals prod.ProductID
                                           into products
                                           // and we are going to select from the result of that goin
                                           from prod in products.DefaultIfEmpty()
                                           select new
                                           {
                                               prod?.ProductID,
                                               prod?.Name,
                                               sale?.OrderQty,
                                               sale?.UnitPrice
                                           }).ToList();
            // SelectMany is used for selecting a list from list
            var selectMany = productSales.SelectMany(r => r.Sales);

            var leftJoinMethodSyntax = productsList.SelectMany(
                sale =>
                salesList.Where(s => sale.ProductID == s.ProductID).DefaultIfEmpty(),
                (prod, sale) => new
                {
                    prod.ProductID,
                    prod.Name,
                    sale?.OrderQty,
                    sale?.UnitPrice
                });
            //-----------------------------Grouping---------------------------------------------
            var groupBy = productsList.GroupBy(r => r.Size);
            var viewGroupBy = productsList.GroupBy(r => r.Size).Select(g => new { size = g.Key, count = g.Count() });
            foreach (var group in groupBy)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
            }

            // There is no Having like sql, but you can execute where on a grouped list
            var having = groupBy.Where(g => g.Key == "M").ToList();
            //-----------------------------Sub Queries---------------------------------------------
            // we want to get list of products for a specefic sale by salesOrderId (one to many relationship)
            // first we are going to join the sales with the products ids
            var subQueryStep1 = salesList.GroupBy(sale => sale.SalesOrderID)
                .Select(sales => new
                {
                    SalesOrderID = sales.Key,
                    ProductsIds = sales.Select(r => r.ProductID).ToList()
                }).ToList();

            // now we want to replace the productIds with the project full object
            // so we are going to add another linq query (a join) inside the select
            // this is called a grouped subquery
            var subQueryStep2 = salesList.GroupBy(sale => sale.SalesOrderID)
                .Select(sales => new
                {
                    SalesOrderID = sales.Key,
                    Products = sales.Join(
                        productsList,
                        sale => sale.ProductID,
                        prod => prod.ProductID,
                        (sale, prod) => prod).ToList()
                }).ToList();
            // TODO: get the same results using the group join

            //-----------------------------Aggregate methods---------------------------------------------
            // Agregate methods calculate single value from property in collection like (count, min, max, average, sum)
            // all of the aggregate methods you can use them direct or with a filter
            var count = productsList.Count();
            var countFiltered = productsList.Count(r => r.NameLength > 25);

            // also you can do it by where then count. TODO: which one is better in performance(the where then count, or the count directly)

            // if you didn't give the min function any parameters you will get this error 'At least one object must implement IComparable'
            var min = productsList.Min(r => r.TotalSales);
            var max = productsList.Max(r => r.TotalSales);
            var avg = productsList.Average(r => r.TotalSales);
            var sum = productsList.Sum(r => r.TotalSales);

            // the aggregate method helps you to create your custom aggregation logic
            var aggregate = productsList.Aggregate(0M,
                // you can also call another method here
                (result, product) => result += (product.TotalSales.Value * 5));

            // aggregates with grouped data
            var grouped = productsList.GroupBy(r => r.Size)
                .Select(r => new
                {
                    size = r.Key,
                    total = r.Count(),
                    min = r.Min(e => e.TotalSales),
                    max = r.Max(e => e.TotalSales),
                    avg = r.Average(e => e.TotalSales),
                    sum = r.Sum(e => e.TotalSales),
                }).ToList();

            // the problem in the previous approach is that you have to loop over the list multiple time for calculating each one of min, max, ...
            // the aggregate method can make this more efficent
            //-----------------------------Deffered Execution---------------------------------------------
            /*
            Deffered execution vs Immediate execution
            Non streaming vs streaming

            Streaming operators do not have to read all the source data before they yield elements
            Non-streaming operators must read all the source data before they can yeild a result element
            Immediate execution means that the data source is read and the operation is performed at the point in the code where the query is declared. 
                All the query operators that return a signle, non-enumberable result execute immediately
            Deffered execution means that the opertation is not performed when the query is declared. 
                The query is ready to be executed, but it's not executed until a value is needed
                it's performed only when the query variable is enumberated for example using a foreach staetment or ToList, OrderBy or Count...
                because in these operators all items are required to be processed

            in this link you can see all the linq operators and each one of them streaming, non-streaming, immediat or deffered executed.
            https://bit.ly/3koPK3n

             */

            debug12.ForEach(x =>
            {
                Console.WriteLine($"{x.ListPrice} - { x.Name }");
            });
        }
    }

    internal class ProductNameComparer : IEqualityComparer<Product>
    {
        public bool Equals([AllowNull] Product x, [AllowNull] Product y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            return obj.ProductID.GetHashCode();
        }
    }
}
