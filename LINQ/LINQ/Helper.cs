﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LINQ
{
    internal class Helper
    {
        public static List<Product> GetList()
        {
            return new List<Product>
      {
        new Product {
          ProductID = 680,
          Name = "HL Road Frame - Black, 58",
          Color = "Black",
          StandardCost = 1059.31M,
          ListPrice = 1431.50M,
          Size = "58",
        },
        new Product {
          ProductID = 706,
          Name = "HL Road Frame - Red, 58",
          Color = "Red",
          StandardCost = 1059.31M,
          ListPrice = 1431.50M,
          Size = "58",
        },
        new Product {
          ProductID = 707,
          Name = "Sport-100 Helmet, Red",
          Color = "Red",
          StandardCost = 13.08M,
          ListPrice = 34.99M,
          Size = null,
        },
        new Product {
          ProductID = 708,
          Name = "Sport-100 Helmet, Black",
          Color = "Black",
          StandardCost = 14.09M,
          ListPrice = 35.99M,
          Size = null,
        },
        new Product {
          ProductID = 709,
          Name = "Mountain Bike Socks, M",
          Color = "White",
          StandardCost = 3.40M,
          ListPrice = 9.50M,
          Size = "M",
        },
        new Product {
          ProductID = 710,
          Name = "Mountain Bike Socks, L",
          Color = "White",
          StandardCost = 3.40M,
          ListPrice = 9.50M,
          Size = "L",
        },
        new Product {
          ProductID = 711,
          Name = "Sport-100 Helmet, Blue",
          Color = "Blue",
          StandardCost = 15.09M,
          ListPrice = 36.99M,
          Size = null,
        },
        new Product {
          ProductID = 712,
          Name = "AWC Logo Cap",
          Color = "Multi",
          StandardCost = 6.92M,
          ListPrice = 8.99M,
          Size = "",
        },
        new Product {
          ProductID = 713,
          Name = "Long-Sleeve Logo Jersey, S",
          Color = "Multi",
          StandardCost = 38.49M,
          ListPrice = 49.99M,
          Size = "S",
        },
        new Product {
          ProductID = 714,
          Name = "Long-Sleeve Logo Jersey, M",
          Color = "Multi",
          StandardCost = 38.49M,
          ListPrice = 49.99M,
          Size = "M",
        },
        new Product {
          ProductID = 715,
          Name = "Long-Sleeve Logo Jersey, L",
          Color = "Multi",
          StandardCost = 38.49M,
          ListPrice = 49.99M,
          Size = "L",
        },
        new Product {
          ProductID = 716,
          Name = "Long-Sleeve Logo Jersey, XL",
          Color = "Multi",
          StandardCost = 38.49M,
          ListPrice = 49.99M,
          Size = "XL",
        },
        new Product {
          ProductID = 717,
          Name = "HL Road Frame - Red, 62",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "62",
        },
        new Product {
          ProductID = 718,
          Name = "HL Road Frame - Red, 44",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "44",
        },
        new Product {
          ProductID = 719,
          Name = "HL Road Frame - Red, 48",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "48",
        },
        new Product {
          ProductID = 720,
          Name = "HL Road Frame - Red, 52",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "52",
        },
        new Product {
          ProductID = 721,
          Name = "HL Road Frame - Red, 56",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "56",
        },
        new Product {
          ProductID = 722,
          Name = "LL Road Frame - Black, 58",
          Color = "Black",
          StandardCost = 204.63M,
          ListPrice = 337.22M,
          Size = "58",
        },
        new Product {
          ProductID = 723,
          Name = "LL Road Frame - Black, 60",
          Color = "Black",
          StandardCost = 204.63M,
          ListPrice = 337.22M,
          Size = "60",
        },
        new Product {
          ProductID = 724,
          Name = "LL Road Frame - Black, 62",
          Color = "Black",
          StandardCost = 204.63M,
          ListPrice = 337.22M,
          Size = "62",
        },
        new Product {
          ProductID = 725,
          Name = "LL Road Frame - Red, 44",
          Color = "Red",
          StandardCost = 187.16M,
          ListPrice = 337.22M,
          Size = "44",
        },
        new Product {
          ProductID = 726,
          Name = "LL Road Frame - Red, 48",
          Color = "Red",
          StandardCost = 187.16M,
          ListPrice = 337.22M,
          Size = "48",
        },
        new Product {
          ProductID = 727,
          Name = "LL Road Frame - Red, 52",
          Color = "Red",
          StandardCost = 187.16M,
          ListPrice = 337.22M,
          Size = "52",
        },
        new Product {
          ProductID = 728,
          Name = "LL Road Frame - Red, 58",
          Color = "Red",
          StandardCost = 187.16M,
          ListPrice = 337.22M,
          Size = "58",
        },
        new Product {
          ProductID = 729,
          Name = "LL Road Frame - Red, 60",
          Color = "Red",
          StandardCost = 187.16M,
          ListPrice = 337.22M,
          Size = "60",
        },
        new Product {
          ProductID = 730,
          Name = "LL Road Frame - Red, 62",
          Color = "Red",
          StandardCost = 187.16M,
          ListPrice = 337.22M,
          Size = "62",
        },
        new Product {
          ProductID = 731,
          Name = "ML Road Frame - Red, 44",
          Color = "Red",
          StandardCost = 352.14M,
          ListPrice = 594.83M,
          Size = "44",
        },
        new Product {
          ProductID = 732,
          Name = "ML Road Frame - Red, 48",
          Color = "Red",
          StandardCost = 352.14M,
          ListPrice = 594.83M,
          Size = "48",
        },
        new Product {
          ProductID = 733,
          Name = "ML Road Frame - Red, 52",
          Color = "Red",
          StandardCost = 352.14M,
          ListPrice = 594.83M,
          Size = "52",
        },
        new Product {
          ProductID = 734,
          Name = "ML Road Frame - Red, 58",
          Color = "Red",
          StandardCost = 352.14M,
          ListPrice = 594.83M,
          Size = "58",
        },
        new Product {
          ProductID = 735,
          Name = "ML Road Frame - Red, 60",
          Color = "Red",
          StandardCost = 352.14M,
          ListPrice = 594.83M,
          Size = "60",
        },
        new Product {
          ProductID = 736,
          Name = "LL Road Frame - Black, 44",
          Color = "Black",
          StandardCost = 204.63M,
          ListPrice = 337.22M,
          Size = "44",
        },
        new Product {
          ProductID = 737,
          Name = "LL Road Frame - Black, 48",
          Color = "Black",
          StandardCost = 204.63M,
          ListPrice = 337.22M,
          Size = "48",
        },
        new Product {
          ProductID = 738,
          Name = "LL Road Frame - Black, 52",
          Color = "Black",
          StandardCost = 204.63M,
          ListPrice = 337.22M,
          Size = "52",
        },
        new Product {
          ProductID = 739,
          Name = "HL Mountain Frame - Silver, 42",
          Color = "Silver",
          StandardCost = 747.20M,
          ListPrice = 1364.50M,
          Size = "42",
        },
        new Product {
          ProductID = 740,
          Name = "HL Mountain Frame - Silver, 44",
          Color = "Silver",
          StandardCost = 706.81M,
          ListPrice = 1364.50M,
          Size = "44",
        },
        new Product {
          ProductID = 741,
          Name = "HL Mountain Frame - Silver, 48",
          Color = "Silver",
          StandardCost = 706.81M,
          ListPrice = 1364.50M,
          Size = "48",
        },
        new Product {
          ProductID = 742,
          Name = "HL Mountain Frame - Silver, 46",
          Color = "Silver",
          StandardCost = 747.20M,
          ListPrice = 1364.50M,
          Size = "46",
        },
        new Product {
          ProductID = 743,
          Name = "HL Mountain Frame - Black, 42",
          Color = "Black",
          StandardCost = 739.04M,
          ListPrice = 1349.60M,
          Size = "42",
        },
        new Product {
          ProductID = 744,
          Name = "HL Mountain Frame - Black, 44",
          Color = "Black",
          StandardCost = 699.09M,
          ListPrice = 1349.60M,
          Size = "44",
        }
      };
        }

        public static List<SalesOrderDetail> GetAllSalesOrderDetails()
        {
            return new List<SalesOrderDetail>
      {
        new SalesOrderDetail
        {
          SalesOrderID = 71774,
          OrderQty = 1,
          ProductID = 680,
          UnitPrice = 356.90M,
          LineTotal = 356.90M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71774,
          OrderQty = 1,
          ProductID = 712,
          UnitPrice = 356.90M,
          LineTotal = 356.90M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71776,
          OrderQty = 1,
          ProductID = 680,
           UnitPrice = 356.90M,
          LineTotal = 356.90M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71780,
          OrderQty = 4,
          ProductID = 707,
          UnitPrice = 218.45M,
          LineTotal = 873.80M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71780,
          OrderQty = 2,
          ProductID = 708,
          UnitPrice = 461.69M,
          LineTotal = 923.38M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71780,
          OrderQty = 6,
          ProductID = 709,
          UnitPrice = 113.00M,
          LineTotal = 678.00M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71781,
          OrderQty = 2,
          ProductID = 709,
          UnitPrice = 818.70M,
          LineTotal = 1637.40M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71781,
          OrderQty = 1,
          ProductID = 710,
          UnitPrice = 323.99M,
          LineTotal = 323.99M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71781,
          OrderQty = 1,
          ProductID = 711,
          UnitPrice = 149.87M,
          LineTotal = 149.87M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71782,
          OrderQty = 1,
          ProductID = 711,
          UnitPrice = 809.76M,
          LineTotal = 809.76M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71782,
          OrderQty = 4,
          ProductID = 712,
          UnitPrice = 1376.99M,
          LineTotal = 5507.96M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71783,
          OrderQty = 2,
          ProductID = 713,
          UnitPrice = 158.43M,
          LineTotal = 316.86M,
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71784,
          OrderQty = 4,
          ProductID = 714,
          UnitPrice = 1391.99M,
          LineTotal = 5567.96M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71784,
          OrderQty = 1,
          ProductID = 715,
          UnitPrice = 48.59M,
          LineTotal = 48.59M,
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71784,
          OrderQty = 6,
          ProductID = 716,
          UnitPrice = 41.99M,
          LineTotal = 251.94M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71784,
          OrderQty = 1,
          ProductID = 717,
          UnitPrice = 113.00M,
          LineTotal = 113.00M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71785,
          OrderQty = 2,
          ProductID = 718,
          UnitPrice = 323.99M,
          LineTotal = 647.98M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71785,
          OrderQty = 3,
          ProductID = 719,
          UnitPrice = 323.99M,
          LineTotal = 971.97M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71786,
          OrderQty = 1,
          ProductID = 720,
          UnitPrice = 323.99M,
          LineTotal = 323.99M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71786,
          OrderQty = 2,
          ProductID = 721,
          UnitPrice = 323.99M,
          LineTotal = 647.98M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71786,
          OrderQty = 2,
          ProductID = 722,
          UnitPrice = 113.00M,
          LineTotal = 226.00M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71787,
          OrderQty = 3,
          ProductID = 723,
          UnitPrice = 113.00M,
          LineTotal = 339.00M,
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71788,
          OrderQty = 3,
          ProductID = 724,
          UnitPrice = 113.00M,
          LineTotal = 339.00M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71788,
          OrderQty = 2,
          ProductID = 725,
          UnitPrice = 461.69M,
          LineTotal = 923.38M,
        },
        new SalesOrderDetail
        {
          SalesOrderID = 71788,
          OrderQty = 3,
          ProductID = 726,
          UnitPrice = 461.69M,
          LineTotal = 1385.082000M
        },
        new SalesOrderDetail
        {
          SalesOrderID = 99988,
          OrderQty = 3,
          ProductID = 9999,
          UnitPrice = 461.69M,
          LineTotal = 1385.07M
        }
      };
        }
        public static List<Product> GetSmallList1()
        {
            return new List<Product>
      {
        new Product {
          ProductID = 680,
          Name = "HL Road Frame - Black, 58",
          Color = "Black",
          StandardCost = 1059.31M,
          ListPrice = 1431.50M,
          Size = "58",
        },
        new Product {
          ProductID = 706,
          Name = "HL Road Frame - Red, 58",
          Color = "Red",
          StandardCost = 1059.31M,
          ListPrice = 1431.50M,
          Size = "58",
        },
        new Product {
          ProductID = 707,
          Name = "Sport-100 Helmet, Red",
          Color = "Red",
          StandardCost = 13.08M,
          ListPrice = 34.99M,
          Size = null,
        },
        new Product {
          ProductID = 708,
          Name = "Sport-100 Helmet, Black",
          Color = "Black",
          StandardCost = 14.09M,
          ListPrice = 35.99M,
          Size = null,
        },
        new Product {
          ProductID = 709,
          Name = "Mountain Bike Socks, M",
          Color = "White",
          StandardCost = 3.40M,
          ListPrice = 9.50M,
          Size = "M",
        },
        new Product {
          ProductID = 710,
          Name = "Mountain Bike Socks, L",
          Color = "White",
          StandardCost = 3.40M,
          ListPrice = 9.50M,
          Size = "L",
        },
        new Product {
          ProductID = 711,
          Name = "Sport-100 Helmet, Blue",
          Color = "Blue",
          StandardCost = 15.09M,
          ListPrice = 36.99M,
          Size = null,
        },
        new Product {
          ProductID = 712,
          Name = "AWC Logo Cap",
          Color = "Multi",
          StandardCost = 6.92M,
          ListPrice = 8.99M,
          Size = "",
        },
        new Product {
          ProductID = 713,
          Name = "Long-Sleeve Logo Jersey, S",
          Color = "Multi",
          StandardCost = 38.49M,
          ListPrice = 49.99M,
          Size = "S",
        },
        new Product {
          ProductID = 714,
          Name = "Long-Sleeve Logo Jersey, M",
          Color = "Multi",
          StandardCost = 38.49M,
          ListPrice = 49.99M,
          Size = "M",
        },
        new Product {
          ProductID = 715,
          Name = "Long-Sleeve Logo Jersey, L",
          Color = "Multi",
          StandardCost = 38.49M,
          ListPrice = 49.99M,
          Size = "L",
        },
        new Product {
          ProductID = 716,
          Name = "Long-Sleeve Logo Jersey, XL",
          Color = "Multi",
          StandardCost = 38.49M,
          ListPrice = 49.99M,
          Size = "XL",
        },
        new Product {
          ProductID = 717,
          Name = "HL Road Frame - Red, 62",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "62",
        },
        new Product {
          ProductID = 718,
          Name = "HL Road Frame - Red, 44",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "44",
        },
        new Product {
          ProductID = 719,
          Name = "HL Road Frame - Red, 48",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "48",
        },
        new Product {
          ProductID = 720,
          Name = "HL Road Frame - Red, 52",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "52",
        },
        new Product {
          ProductID = 721,
          Name = "HL Road Frame - Red, 56",
          Color = "Red",
          StandardCost = 868.63M,
          ListPrice = 1431.50M,
          Size = "56",
        },
        new Product {
          ProductID = 722,
          Name = "LL Road Frame - Black, 58",
          Color = "Black",
          StandardCost = 204.63M,
          ListPrice = 337.22M,
          Size = "58",
        }
      };
        }

        public static List<Product> GetSmallList2()
        {
            return new List<Product>
      {
        new Product {
          ProductID = 680,
          Name = "HL Road Frame - Black, 58",
          Color = "Black",
          StandardCost = 1059.31M,
          ListPrice = 1431.50M,
          Size = "58",
        },
        new Product {
          ProductID = 706,
          Name = "HL Road Frame - Red, 58",
          Color = "Red",
          StandardCost = 1059.31M,
          ListPrice = 1431.50M,
          Size = "58",
        },
        new Product {
          ProductID = 707,
          Name = "Sport-100 Helmet, Red",
          Color = "Red",
          StandardCost = 13.08M,
          ListPrice = 34.99M,
          Size = null,
        },
        new Product {
          ProductID = 708,
          Name = "Sport-100 Helmet, Black",
          Color = "Black",
          StandardCost = 14.09M,
          ListPrice = 35.99M,
          Size = null,
        },
        new Product {
          ProductID = 709,
          Name = "Mountain Bike Socks, M",
          Color = "White",
          StandardCost = 3.40M,
          ListPrice = 9.50M,
          Size = "M",
        }
      };
        }
    }

    internal class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public int? NameLength { get; set; }
        public decimal? TotalSales { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.Append(Name);
            sb.AppendLine($"  ID: {ProductID}");
            sb.Append($"   Color: {Color}");
            sb.AppendLine($"   Size: {(Size ?? "n/a")}");
            sb.Append($"   Cost: {StandardCost:c}");
            sb.AppendLine($"   Price: {ListPrice:c}");
            if (NameLength.HasValue)
            {
                sb.AppendLine($"   Name Length: {NameLength}");
            }
            if (TotalSales.HasValue)
            {
                sb.AppendLine($"   Total Sales: {TotalSales:c}");
            }
            return sb.ToString();
        }
    }

    internal class SalesOrderDetail
    {
        public int SalesOrderID { get; set; }
        public short OrderQty { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.AppendLine($"Order ID: {SalesOrderID}");
            sb.Append($"   Product ID: {ProductID}");
            sb.AppendLine($"   Qty: {OrderQty}");
            sb.Append($"   Unit Price: {UnitPrice:c}");
            sb.AppendLine($"   Total: {LineTotal:c}");

            return sb.ToString();
        }
    }
    internal class ProductSales
    {
        public Product Product { get; set; }
        public IEnumerable<SalesOrderDetail> Sales { get; set; }
    }
}
