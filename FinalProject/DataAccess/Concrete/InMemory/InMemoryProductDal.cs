using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{CategoryId=1,ProductId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{CategoryId=2,ProductId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{CategoryId=2,ProductId=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{CategoryId=2,ProductId=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDeleted = null; // referansı null olan bir ürün  tanımladık
            //foreach (var p in _products) // veri öğelerini p takma adıyla tek tek geziyoruz
            //{
            //    if (product.ProductId == p.ProductId) //eğer  delete'e verilen öğe ile p nin ıd si aynıysa
            //    {
            //        productToDeleted = p; // referansı olmayana pnin referansını ver
            //    }
            //}
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete); // sonuç olarak p 'nin adresini/referansını (artık canın ne demek isterse)sil
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;// tüm ürünleri döndür
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //Category'e göre filtreleme
            //CategoryId'si girilen category ıd'ye eşit olan ürünleri liste halinde getir
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün ıdsine sahip listedeki  ürünü bul referansını productToUpdate ata
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
            // Veri kaynağındaki referansın bilgilerini ekrandan gelen verilerle güncelliyoruz
            //işin mantığı=>EntityFramework 
        }
    }
}
