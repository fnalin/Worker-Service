using Fansoft.WorkerService.Repository;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Fansoft.WorkerService.Services
{

    public class InfoWorker : IHostedService
    {
        private Timer _timer;
        private readonly ICommandRepository _commandRepository;

        public InfoWorker(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Processor started => {nameof(InfoWorker)}");

            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(1));
            return Task.CompletedTask;
        }

        private void DoWork(object state) => 
            Console.WriteLine($" {DateTime.UtcNow:o} => {_commandRepository.GetMessage()}");

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Processor finished => {nameof(InfoWorker)}");
            return Task.CompletedTask;
        }
    }
}
