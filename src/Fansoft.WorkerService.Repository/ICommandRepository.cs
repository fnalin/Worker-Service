using Fansoft.WorkerService.Domain;

namespace Fansoft.WorkerService.Repository
{
    public interface ICommandRepository
    {
        string GetMessage();
        void SetMessage(Message message);
    }
}