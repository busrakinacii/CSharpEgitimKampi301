using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {

    }
}
/*
 * Ekle,Sil,Güncelle,Listele ve Id'ye göre Getir
 * Entityye özgü olmayan metotlar
 * sistemdeki bütün entityler kullanabilir
 * İçinde a harfi geçmeyen kullanıcıları liseleme bu sadece bir entitye özgü olur
 */