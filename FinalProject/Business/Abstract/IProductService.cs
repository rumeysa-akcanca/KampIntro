using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IProductService
        //iş Kodları
    {
        List<Product> GetAll();// tüm rünleri listele
    }
}
