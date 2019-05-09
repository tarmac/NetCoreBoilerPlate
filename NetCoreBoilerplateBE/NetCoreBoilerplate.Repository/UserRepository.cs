using NetCoreBoilerplate.Entities;
using NetCoreBoilerplate.Entities.Models;
using NetCoreBoilerPlate.Repo.Definition;

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