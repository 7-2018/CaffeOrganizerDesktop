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
        public List<CaffeTable> getCaffeTables()
        {
            return this.tableRepository.GetCaffeTables();
        }
        public bool InsertCaffeTable(CaffeTable caffeTable)
        {
            int result = this.tableRepository.InsertCaffeTable(caffeTable);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteTable(int tableId)
        {
            int result = this.tableRepository.DeleteTable(tableId);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateTable(CaffeTable caffeTable)
        {
            int result = this.tableRepository.UpdateTable(caffeTable);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
