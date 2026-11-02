
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        Admin GetByUserName(string username);
        Admin GetAdmin(string username, string password);
    }
}
