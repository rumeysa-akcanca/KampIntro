using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> {
            new Category { CategoryId=1, CategoryName="Bilgisayar"},
            new Category { CategoryId=2,CategoryName="Telefon"}
            };

            List<Product> products = new List<Product> { 
            new Product{CategoryId=1, ProductId=1, ProductName="Asus Laptop",UnitPrice=10000 },
            new Product{CategoryId=1, ProductId=2, ProductName="Acer Laptop",UnitPrice=8000 },
            new Product{CategoryId=1, ProductId=3, ProductName="HP Laptop",UnitPrice=6000 },
            new Product{CategoryId=2, ProductId=4, ProductName="Samsung Telefon",UnitPrice=5000 },
            new Product{CategoryId=2, ProductId=5, ProductName="Apple Telefon",UnitPrice=8000 }
            };
            Console.WriteLine("Algoritmik..............................");
            foreach (var product in products)
            {
                if (product.UnitPrice>5000 && product.CategoryId==1)
                {
                Console.WriteLine(product.ProductName);
                }

            }
            Console.WriteLine("Linq........................................");
            var result = products.Where(p => p.UnitPrice > 5000 && p.CategoryId == 1);
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }

            static 
        }
    }
}
