using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //OLMAMASI GEREKEN BİR Interface yalnızda Category tablosuna özel olmamalı tüm entity tablolarını kapsamalı.Buyüzden IRepository oluşturuldu
    public interface ICategoryDAL:IRepository<Category>
    {
        //CRUD   interface method oluştururken  Type name();


        //List<Category> List();
        //void Insert(Category p);
        //void Update(Category p);
        //void Delete(Category p);
    }
}
