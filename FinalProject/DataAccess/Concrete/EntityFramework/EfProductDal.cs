using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //EntityFramework:Object Relational Mapping (ORM) bir ürün.
    //lind destekli, veri tabaındaki tabloyu sanki bir classmış gibi onunla ilişkilendirip sql leri linq ile yaptığımız ortam
    //veri tabanı nesneleri ile kodlar arasında bir bağ kurup veri tabanı işlerini yapma süreci
    //NuGet: başkalarının yazdığı kodlar: paketler
    //EntityFramework paketi varmış default olarak
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

      
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
