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

        public static CaffeWorker currentWoker;

        public CaffeWorker getsetworker
        {
            get { return currentWoker; }
            set { currentWoker = value; }
        }
            public WorkerBusiness()
            {
            this.workerRepository = new WorkerRepository();
            }
        public List<CaffeWorker> GetCaffeWorkers()
            {
            return this.workerRepository.GetCaffeWorkers();
            }
        public bool InsertCaffeWorker(CaffeWorker caffeWorker)
        {
            int result = this.workerRepository.InsertCaffeWorker(caffeWorker);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteWorker(int workerId)
        {
            int result = this.workerRepository.DeleteWorker(workerId);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateWorker(CaffeWorker caffeWorker)
        {
            int result = this.workerRepository.UpdateWorker(caffeWorker);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
