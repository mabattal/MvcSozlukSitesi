using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD operasyonlarını metot olarak tanımlıyoruz.
        //Type Name();

        //Listeleme
        List<Category> List();

        //Ekleme
        void Insert(Category p);

        //Güncelleme
        void Update(Category p);

        //Silme
        void Delete(Category p);
    }
}
