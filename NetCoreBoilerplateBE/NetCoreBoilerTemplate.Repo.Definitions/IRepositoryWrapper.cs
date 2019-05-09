namespace NetCoreBoilerPlate.Repo.Definition
{
    public interface IRepositoryWrapper
    {
        IMessageRepository Message { get; }
        IMessageTypeRepository MessageType { get; }
        IUserRepository User { get; }
    }
}