using NetCoreBoilerplate.Contracts;
using NetCoreBoilerplate.Entities;

namespace NetCoreBoilerplate.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IMessageRepository _message;
        private IMessageTypeRepository _messageType;
        private IUserRepository _user;

        public IMessageRepository Message
        {
            get
            {
                if (_message == null)
                    _message = new MessageRepository(_repoContext);

                return _message;
            }
        }

        public IMessageTypeRepository MessageType
        {
            get
            {
                if (_messageType == null)
                    _messageType = new MessageTypeRepository(_repoContext);

                return _messageType;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                    _user = new UserRepository(_repoContext);

                return _user;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}