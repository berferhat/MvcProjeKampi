using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetAdmin(string username, string password)
        {
            return _adminDal.Get(x => x.AdminUserName == username && x.AdminPassword == password);
        }

        public Admin GetByUserName(string username)
        {
            return _adminDal.Get(x => x.AdminUserName == username);
        }
    }
}
