using DataAccessLayer.DbContexts;
using Models.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var conn = new TodebCampDbContext()) //TodebDbContext database'ini conn objesine eşitliyoruz.
            {
                //var cat = new Category //Category entity'sini cat objesine eşitliyoruz.
                //{
                //    CategoryName = "Kahvaltı", //CategoryName değerini veriyoruz.
                //    Description = "Kahvaltı için gerekli olanlar" //Description değerini veriyoruz.
                //};
                //conn.Categories.Add(cat); //database'in Categories kolonuna Add metodu ile oluşturduğumuz objeyi ekliyoruz.
                //conn.SaveChanges(); //database'i SaveChanges metodu ile kaydediyoruz.
                
                //var cat2 = new Category
                //{
                //    CategoryName = "Yemek",
                //    Description = "5557778899",
                //    Products = new List<Product>()
                //    {
                //        new Product()
                //        {
                //            Discontinued = false,
                //            ProductName = "Köfte",
                //            ProductDetail = "Leziz",
                //            SupplierID = 1,
                //            UnitPrice = 50,
                //            UnitsInStock = 10,
                //            UnitsOnOrder = 5,
                //            QuantityPerUnit = "5",
                //            ReorderLevel = 6,
                //        },
                //        new Product()
                //        {
                //            Discontinued = false,
                //            ProductName = "Döner",
                //            ProductDetail = "Leziz",
                //            SupplierID = 1,
                //            UnitPrice = 45,
                //            UnitsInStock = 20,
                //            UnitsOnOrder = 5,
                //            QuantityPerUnit = "4",
                //            ReorderLevel = 6,
                //        }
                //    }
                //};
                //conn.Categories.Add(cat2);
                //conn.SaveChanges();
            }
        }
    }
}
