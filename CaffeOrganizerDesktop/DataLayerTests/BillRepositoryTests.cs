using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Tests
{
    [TestClass()]
    public class BillRepositoryTests
    {
        CaffeBill cb;
        BillRepository bir;
        [TestInitialize]
        public void init()
        {
            cb = new CaffeBill(9999, 1, 98765, DateTime.Now, true);
            bir = new BillRepository();
        }
        [TestMethod()]
        public void GetCaffeBillsTest()
        {
            bir.InsertCaffeBill(cb);
            Assert.IsNotNull(bir.GetCaffeBills());
        }
        [TestMethod()]
        public void DeleteCaffeBillsTest()
        {
            bir.InsertCaffeBill(cb);
            CaffeBill c = bir.GetCaffeBills().Where(x => x.Total_Price == cb.Total_Price).ToList()[0];
            int result = bir.DeleteCaffeBill(c.Bill_ID);
            bir.InsertCaffeBill(cb);
            Assert.IsTrue(result > 0);
        }
        [TestMethod()]
        public void UpdateCaffeBillsTest()
        {
            bir.InsertCaffeBill(cb);
            CaffeBill c = bir.GetCaffeBills().Where(x => x.Total_Price == cb.Total_Price).ToList()[0];
            c.Paid = false;
            int result = bir.UpdateCaffeBill(c);
            Assert.IsTrue(result > 0);
        }
        [TestCleanup]
        public void clean()
        {
            CaffeBill c = bir.GetCaffeBills().Where(x => x.Total_Price == cb.Total_Price).ToList()[0];
            bir.DeleteCaffeBill(c.Bill_ID);
        }
    }
}