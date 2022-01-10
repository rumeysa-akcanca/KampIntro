using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //iş katmanın somut sınıfı:manager
        //veri katmaını çagırıyoruz ,ınmemory,framework ,Hypper... hepsi birer veri erişim alternatifleri
        //bi riş sınıfı başka bir sınıfı newlemez
        IProductDal _productDal;// soyut nesne ile bağlantı kuracaz
        public ProductManager(IProductDal productDal)
        {
            //ProductManager newlwndiğinde bana IProductDal referansı ver
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //iş kodları
            //yetkisi var mı
            // ifleri vs kuralları geçtiyse  listeyi ver
            return _productDal.GetAll();
        }
    }
}
