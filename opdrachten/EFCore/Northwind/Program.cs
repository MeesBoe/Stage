using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Northwind;

namespace Northwind.Data
{
    class Program
    {
        private static string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Northwind";

        static void Main(string[] args)
        {
            //ToonCategories();
            //ToonProducts();
            //ToonSuppliers();
            //ToonSupplierProducts();

            int orderID = HaalOrderID();

            ToonOrder(orderID);
        }

        private static void ToonCategories()
        {
            var db = new NorthwindDbContext(_connectionString);
            var categories = db.Categories.ToList();

            foreach (var category in categories)
            {
                Console.Write($"{category.CategoryID}: ");
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ToonProducts()
        {
            Console.WriteLine();
            Console.WriteLine("Welke categorie wilt u inzien?");
            Console.WriteLine();
            string CategoryInput = Console.ReadLine();
            int.TryParse(CategoryInput, out int CategoryOutput);
            var db = new NorthwindDbContext(_connectionString);
            var products = db.Products.Where(c => c.CategoryID == CategoryOutput).Include(p => p.Category).ToList();

            foreach (var product in products)
            {
                Console.WriteLine(product.Category.CategoryName);
                Console.Write($"{product.ProductID}: ");
                Console.Write(product.ProductName + " ");
                Console.Write(product.QuantityPerUnit);
            }
        }

        private static void ToonSuppliers()
        {
            var db = new NorthwindDbContext(_connectionString);
            var suppliers = db.Suppliers.ToList();

            foreach (var supplier in suppliers)
            {
                Console.Write($"{supplier.SupplierID}: ");
                Console.WriteLine(supplier.CompanyName);
            }
        }

        private static void ToonSupplierProducts()
        {
            Console.WriteLine();
            Console.WriteLine("Geef een ID: ");
            Console.WriteLine();
            string SupplierInput = Console.ReadLine();
            int.TryParse(SupplierInput, out int SupplierOutput);
            var db = new NorthwindDbContext(_connectionString);
            var suppliers = db.Products.Where(c => c.SupplierID == SupplierOutput)
                                       .Include(s => s.Supplier)
                                       .Include(c => c.Category)
                                       .OrderBy(o => o.Category.CategoryName)
                                       .ToList();

            int counter = 1;

            foreach (var supplier in suppliers)
            {
                Console.Write(counter++ + " ");
                Console.Write($"ID:{supplier.SupplierID}, ");
                Console.Write($"{supplier.ProductName}, ");
                Console.Write($"{supplier.Supplier.CompanyName}, ");
                Console.WriteLine(supplier.Category.CategoryName);
            }
        }

        private static int HaalOrderID()
        {
            Console.WriteLine("Welk order wilt u inzien? ");
            int.TryParse (Console.ReadLine(), out int orderID);

            return orderID;
        }

        private static void ToonOrder(int orderID)
        {
            Console.Clear();
            OrderHeader(orderID);
            OrderDetails(orderID);
        }

        private static void OrderHeader(int orderID)
        {
            var db = new NorthwindDbContext(_connectionString);
            var orders = db.Orders.Where(o => o.OrderID == orderID)
                                        .Include(c => c.Customer)
                                        .ToList();

            foreach (var order in orders)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(order.Customer.CompanyName);
                Console.WriteLine(order.Customer.ContactName);
                Console.WriteLine(order.Customer.Address);
                Console.WriteLine(order.Customer.City);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Order:{order.OrderID}");
                Console.WriteLine($"Date:{order.OrderDate}");
                Console.WriteLine();
                Console.ResetColor();
            }
        }
         
        private static void OrderDetails(int orderID)
        {
            var db = new NorthwindDbContext(_connectionString);
            var orders = db.OrderDetails.Where(o => o.OrderID == orderID)
                        .Include(p => p.Product)
                        .ThenInclude(p => p.Category)
                        .OrderBy(o => o.Product.Category.CategoryName);

            foreach (var order in orders)
            {
                var Total = order.Quantity * order.UnitPrice;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Category");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(order.Product.Category.CategoryName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Product");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(order.Product.ProductName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("UnitPrice");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(order.UnitPrice);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Quantity");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(order.Quantity);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Total");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Total);
                Console.ResetColor();
            }
        }
    }
}