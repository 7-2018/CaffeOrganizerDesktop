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
    public class ArticleRepositoryTests
    {
        public CaffeArticle a;
        public ArticleRepository ar;
        [TestInitialize]
        public void init()
        {
            a = new CaffeArticle(9999, "TestTestTest1", 100, "TestTestTest");
            ar = new ArticleRepository();
        }
        [TestMethod()]
        public void GetCaffeArticlesTest()
        {
            ar.InsertCaffeArticle(a);
            Assert.IsNotNull(ar.GetCaffeArticles());
        }
        [TestMethod()]
        public void DeleteArticleTest()
        {
            ar.InsertCaffeArticle(a);
            CaffeArticle c = ar.GetCaffeArticles().Where(x => x.Name == a.Name).ToList()[0];
            Assert.IsTrue(ar.DeleteArticle(c.Article_ID) > 0);
            ar.InsertCaffeArticle(a);
        }
        [TestMethod()]
        public void UpdateArticleTest()
        {
            ar.InsertCaffeArticle(a);
            CaffeArticle c = ar.GetCaffeArticles().Where(x => x.Name == a.Name).ToList()[0];
            int result = ar.UpdateArticle(c);
            Assert.IsTrue(result > 0);
        }
        [TestCleanup]
        public void clean()
        {
            CaffeArticle c = ar.GetCaffeArticles().Where(x => x.Name == a.Name).ToList()[0];
            ar.DeleteArticle(c.Article_ID);
        }
    }
}