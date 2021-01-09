using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboProduto.Interfaces;
using Robo.Domain.Interfaces;
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

            taskRobo.RunWorkerAsync();
        }

        public void Parar()
        {
            taskRobo.CancelAsync();
        }
    }
}
