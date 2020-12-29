using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class CaffeBillItem
    {
        private int article_ID;
        private int bill_ID;
        private int quantity;

        public CaffeBillItem(int article_ID, int bill_ID, int quantity)
        {
            this.Article_ID = article_ID;
            this.Bill_ID = bill_ID;
            this.Quantity = quantity;
        }

        public int Article_ID { get => article_ID; set => article_ID = value; }
        public int Bill_ID { get => bill_ID; set => bill_ID = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public override string ToString()
        {
            return $"{article_ID}-{bill_ID}-{quantity}";
        }
    }
}
