using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //Context sınıfı; yazılan DbSet türündeki propertyleri Sql'e birer tablo olarak yansıtır.
    public class Context : DbContext
    {
        //About EntityLayer daki sınıfın ismi, Abouts; Sql deki tablonun ismi
        //Pluralize kuralları gereği s takısı geliyor.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
