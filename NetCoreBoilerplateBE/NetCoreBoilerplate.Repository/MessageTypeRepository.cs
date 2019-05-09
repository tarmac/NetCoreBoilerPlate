using NetCoreBoilerplate.Entities;
using NetCoreBoilerplate.Entities.Models;
using NetCoreBoilerPlate.Repo.Definition;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreBoilerplate.Repository
{
    public class MessageTypeRepository : RepositoryBase<MessageType>, IMessageTypeRepository
    {
        public MessageTypeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<MessageType> GetAllMessageTypes()
        {
            return FindAll()
                    .OrderBy(m => m.Name);
        }

        public MessageType GetMessageTypeById(long messageTypeId)
        {
            return FindByCondition(m => m.Id == messageTypeId)
                    .FirstOrDefault();
        }

        public void CreateMessageType(MessageType messageType)
        {
            Create(messageType);
            Save();
        }

        public void CreateThanksMessage()
        {
            var thanksMessage = new MessageType
            {
                Name = "Thanks"
            };
            Create(thanksMessage);
            Save();
        }

        public void CreateThanksMessage(MessageType thanksMessage)
        {
            throw new System.NotImplementedException();
        }
    }
}