using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TableBusiness
    {
        private TableRepository tableRepository;
        public TableBusiness()
        {
            this.tableRepository = new TableRepository();
        }
        public List<CaffeTable> getCaffeWorkers()
        {
            return this.tableRepository.GetCaffeTables();
        }
    }
}
