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
    public class TableRepositoryTests
    {
        public CaffeTable t;
        public TableRepository tr;

        [TestInitialize]
        public void init()
        {
            t = new CaffeTable(3, 1, 4, false);
            tr = new TableRepository();
        }
        [TestMethod()]
        public void GetCaffeTablesTest()
        {

            tr.InsertCaffeTable(t);
            Assert.IsNotNull(tr.GetCaffeTables());
        }
        [TestMethod()]
        public void DeleteArticleTest()
        {
            tr.InsertCaffeTable(t);
        
            Assert.IsTrue(tr.DeleteTable(t.Table_ID) > 0);
        }
        [TestMethod()]
        public void UpdateArticleTest()
        {

            tr.InsertCaffeTable(t);
            t.Number_Of_Seats = 6;
            int result = tr.UpdateTable(t);

            Assert.IsTrue(result > 0);
        }
        [TestCleanup]
        public void clean()
        {

            tr.DeleteTable(t.Table_ID);
        }
    }
}