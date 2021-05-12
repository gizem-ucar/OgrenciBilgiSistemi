using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Core.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici, OBSContext>, IKullaniciDal
    {

    }
}
