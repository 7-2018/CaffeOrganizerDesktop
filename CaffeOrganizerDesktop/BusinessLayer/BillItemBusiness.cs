using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BillItemBusiness
    {
        private BillItemRepository billItemRepository;
        public BillItemBusiness()
        {
            this.billItemRepository = new BillItemRepository();
        }
        public List<CaffeBillItem> GetCaffeBillItems()
        {
            return this.billItemRepository.GetCaffeBillItems();
        }
        public bool InsertBillItem(CaffeBillItem caffeBillItem)
        {
            int result = this.billItemRepository.InsertCaffeBillItem(caffeBillItem);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteBillItem(int ItemId, int billId)
        {
            int result = this.billItemRepository.DeleteBillItem(ItemId, billId);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateBillItem(CaffeBillItem caffeBillItem)
        {
            int result = this.billItemRepository.UpdateBillItem(caffeBillItem);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
