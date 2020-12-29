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
    public class BillItemRepositoryTests
    {
        public CaffeBillItem c;
        public BillItemRepository cr;

        [TestInitialize]
        public void init()
        {
            c = new CaffeBillItem(84, 3, 1);
            cr = new BillItemRepository();
        }
        [TestMethod()]
        public void GetCaffeBillItemsTest()
        {
            cr.InsertCaffeBillItem(c);
            Assert.IsNotNull(cr.GetCaffeBillItems());
        }
        [TestMethod()]
        public void DeleteBillItemTest()
        {
            cr.InsertCaffeBillItem(c);
          
            Assert.IsTrue(cr.DeleteBillItem(c.Article_ID, c.Bill_ID)> 0);
        }
        [TestMethod()]
        public void UpdateArticleTest()
        {

            cr.InsertCaffeBillItem(c);
            c.Quantity = 3;
            int result = cr.UpdateBillItem(c);
           
            Assert.IsTrue( result > 0);
        }
        [TestCleanup]
        public void clean()
        {
            cr.DeleteBillItem(c.Article_ID, c.Bill_ID);
        }
    }
}