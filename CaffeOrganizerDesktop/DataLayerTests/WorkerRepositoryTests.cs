using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tests
{
    [TestClass()]
    public class WorkerRepositoryTests
    {
        CaffeWorker cw;
        WorkerRepository wr;
        [TestInitialize]
        public void init()
        {
            cw = new CaffeWorker(9999, "pass", "Test", "test@test.com", "00000");
            wr = new WorkerRepository();
        }
        [TestMethod()]
        public void GetCaffeWorkersTest()
        {
            wr.InsertCaffeWorker(cw);
            Assert.IsNotNull(wr.GetCaffeWorkers());
        }

        [TestMethod()]
        public void UpdateCaffeWorkersTest()
        {
            wr.InsertCaffeWorker(cw);
            CaffeWorker c = wr.GetCaffeWorkers().Where(x => x.User_Name == cw.User_Name).ToList()[0];
            c.Password = "pass2";
            int result = wr.UpdateWorker(c);
            Assert.IsTrue(result > 0);
        }

        [TestMethod()]
        public void DeleteCaffeWorkersTest()
        {
            wr.InsertCaffeWorker(cw);
            CaffeWorker c = wr.GetCaffeWorkers().Where(x => x.User_Name == cw.User_Name).ToList()[0];
            int result = wr.DeleteWorker(c.Worker_ID);
            wr.InsertCaffeWorker(cw);
            Assert.IsTrue(result > 0);
        }

        [TestCleanup]
        public void clean()
        {
            CaffeWorker c = wr.GetCaffeWorkers().Where(x => x.User_Name == cw.User_Name).ToList()[0];
            wr.DeleteWorker(c.Worker_ID);
        }
    }
}