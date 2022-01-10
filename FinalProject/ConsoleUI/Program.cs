using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //parantez iindeki çalıştığı veri yöntemi
            ProductManager productmanager = new ProductManager (new EfProductDal());
            foreach (var product in productmanager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
