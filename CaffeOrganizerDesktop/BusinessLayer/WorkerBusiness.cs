using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WorkerBusiness
    {
            private WorkerRepository workerRepository;
            public WorkerBusiness()
            {
            this.workerRepository = new WorkerRepository();
            }
        public List<CaffeWorker> GetCaffeWorkers()
            {
            return this.workerRepository.GetCaffeWorkers();
            }
    }
}
