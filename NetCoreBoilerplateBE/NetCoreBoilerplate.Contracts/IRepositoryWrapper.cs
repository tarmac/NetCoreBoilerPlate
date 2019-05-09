namespace NetCoreBoilerplate.Contracts
{
    public interface IRepositoryWrapper
    {
        IMessageRepository Message { get; }
        IMessageTypeRepository MessageType { get; }
        IUserRepository User { get; }
    }
}