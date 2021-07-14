using Fansoft.WorkerService.Domain;
using System;

namespace Fansoft.WorkerService.Repository
{
    public class CommandRepository : ICommandRepository
    {
        private Message _message = new Message { Content = "..." };


        public string GetMessage() => _message.Content;

        public void SetMessage(Message message) => _message = message;
    }
}
