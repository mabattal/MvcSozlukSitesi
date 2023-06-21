using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Tek tek tablo adı belirtmek yerine T ile hangi entity ile işlem yapacaksak onu göndererek üzerinde işlem yapabiliriz.
    public interface IRepository<T>
    {
        //herşeyi listeleme
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);

        //şartlı listeleme(filtreleme)
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
