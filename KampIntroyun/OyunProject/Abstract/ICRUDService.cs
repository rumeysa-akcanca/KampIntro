using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Abstract
{
    public interface ICRUDService<T>
    {
        void Register(T entity);
        void Delete(T entity);
        void Update(T entity);
        

    }
}
