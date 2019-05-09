using NetCoreBoilerplate.Entities.Models;
using System.Collections.Generic;

namespace NetCoreBoilerplate.Contracts
{
    public interface IMessageTypeRepository : IRepositoryBase<MessageType>
    {
        IEnumerable<MessageType> GetAllMessageTypes();

        MessageType GetMessageTypeById(long messageTypeId);

        void CreateMessageType(MessageType messageType);

        void CreateThanksMessage(MessageType thanksMessage);

    }
}