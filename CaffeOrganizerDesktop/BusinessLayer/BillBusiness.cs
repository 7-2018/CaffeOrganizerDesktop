using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class BillBusiness
    {
        private BillRepository billRepository;
        public BillBusiness()
        {
            this.billRepository = new BillRepository();
        }
        public List<CaffeBill> getCaffeBills()
        {
            return this.billRepository.GetCaffeBills();
        }
        public bool InsertCaffeBill(CaffeBill caffeBill)
        {
            int result = this.billRepository.InsertCaffeBill(caffeBill);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteCaffeBill(int billId)
        {
            int result = this.billRepository.DeleteCaffeBill(billId);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateCaffeBill(CaffeBill caffeBill)
        {
            int result = this.billRepository.UpdateCaffeBill(caffeBill);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
