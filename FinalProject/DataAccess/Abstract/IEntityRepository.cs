using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //t yi sınırlandırmak istiyoruz,Veri tabanı nesnelerini gelsin sadece
    //generic constraint:generic kısıt
    //class: demek T referans tip olabilir demek 
    //IEntity : T ya IEntity ya da ondan implemente eden bir nesne olmalı
   public interface IEntityRepository<T> where T :class,IEntity,new()
    {
        //Expression:ifade
        //Refactoring ?? Tipini döndüren, Tasarlanacak yapı filtreli olsun, ürünlerin bir kısmı gelsin
        List<T> GetAll(Expression<Func<T,bool>> filter=null);// filte varsa filtreleyip ver
        //Delege??
        T Get(Expression<Func<T, bool>> filter);// gelen listedeki itemlerden tek bir tanesinin detaylarına gitmek için kullanılır
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
