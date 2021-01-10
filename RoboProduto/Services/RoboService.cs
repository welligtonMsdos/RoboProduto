using Robo.Domain.Interfaces;
using RoboProduto.Interfaces;
using System;
using System.ComponentModel;
using System.Threading;

namespace RoboProduto.Services
{
    public class RoboService : IRoboService
    {
        private readonly IProdutoRep _produtoRep;
        private readonly ILogger _logger;
        private BackgroundWorker taskRobo = new BackgroundWorker();
        
        public RoboService(IProdutoRep produtoRep, ILogger logger)
        {
            _produtoRep = produtoRep;
            _logger = logger;
        }
        public void Iniciar()
        {
            taskRobo.WorkerSupportsCancellation = false;

            taskRobo.DoWork += (s, e) =>
            {
                while(taskRobo.WorkerSupportsCancellation == false)
                {
                    // A cada 1 minuto (60000)
                    // A cadas 5 segundos (5000)

                    Thread.Sleep(5000);

                    try
                    {                       
                       _logger.LogMsg(_produtoRep.GetAll());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            };

            if(!taskRobo.IsBusy) taskRobo.RunWorkerAsync();
        }

        public void Parar()
        {            
            if (taskRobo.IsBusy)
            {
                taskRobo.WorkerSupportsCancellation = true;
                taskRobo.CancelAsync();                
            }
        }
    }
}
