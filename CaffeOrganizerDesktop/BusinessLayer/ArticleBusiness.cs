using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class ArticleBusiness
    {
        private DataLayer.ArticleRepository articleRepository;
        public ArticleBusiness()
        {
            this.articleRepository = new DataLayer.ArticleRepository();
        }
        public List<CaffeArticle> GetCaffeArticles()
        {
            return this.articleRepository.GetCaffeArticles();
        }
        public bool InsertCaffeArticle(CaffeArticle caffeArticle)
        {
            int result = this.articleRepository.InsertCaffeArticle(caffeArticle);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool DeleteArticle(int articleId)
        {
            int result = this.articleRepository.DeleteArticle(articleId);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateArticle(CaffeArticle caffeArticle)
        {
            int result = this.articleRepository.UpdateArticle(caffeArticle);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
