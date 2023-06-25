using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        //GenericRepository'e Category'i yollayıp ilgili propertyleri çalıştıracağız.
        //başlangıçta mantığını oturtmak için bu şekilde ilerliyoruz, ilerde daha efektif olarak businessLayer'ı düzenleyeceğiz.
        GenericRepository<Category> repo = new GenericRepository<Category>();

        //listeleme
        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        //ekleme
        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            {
                //Hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
