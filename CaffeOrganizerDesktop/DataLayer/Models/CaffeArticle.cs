using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class CaffeArticle
    {
        private int article_ID;
        private string name;
        private int price;
        private string packaging;

        public CaffeArticle(int article_ID, string name, int price, string packaging)
        {
            this.Article_ID = article_ID;
            this.Name = name;
            this.Price = price;
            this.Packaging = packaging;
        }

        public int Article_ID { get => article_ID; set => article_ID = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Packaging { get => packaging; set => packaging = value; }

        public override string ToString()
        {
            return $"{article_ID}-{name}-{price}-{packaging}";
        }
    }
}
