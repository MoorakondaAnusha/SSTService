using SSTDataAccess;
using SSTRepository;

namespace SSTService
{
    public class UserService:IUserService
    {
        private IRepository<UserRole> userRoleRepository;

        public UserService(IRepository<UserRole> userRoleRepository)
        {
            this.userRoleRepository = userRoleRepository;
        }

        public UserRole GetUserRoleMapping(int id)
        {
            return userRoleRepository.Get(id);
        }
    }
}
