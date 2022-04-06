using SSTDataAccess;

namespace SSTService
{
    public interface IUserService
    {
        UserRole GetUserRoleMapping(int id);
    }
}
