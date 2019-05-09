using NetCoreBoilerplate.Contracts;
using NetCoreBoilerplate.Entities;
using NetCoreBoilerplate.Entities.Models;

namespace NetCoreBoilerplate.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}