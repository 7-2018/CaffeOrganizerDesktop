using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class CaffeBill
    {
        private int bill_ID;
        private int table_ID;
        private int total_Price;
        private DateTime date_And_Time;
        private bool paid;

        public CaffeBill(int bill_ID, int table_ID, int total_Price, DateTime date_And_Time, bool paid)
        {
            this.Bill_ID = bill_ID;
            this.Table_ID = table_ID;
            this.Total_Price = total_Price;
            this.Date_And_Time = date_And_Time;
            this.paid = paid;
        }

        public int Bill_ID { get => bill_ID; set => bill_ID = value; }
        public int Table_ID { get => table_ID; set => table_ID = value; }
        public int Total_Price { get => total_Price; set => total_Price = value; }
        public DateTime Date_And_Time { get => date_And_Time; set => date_And_Time = value; }
        public bool Paid { get => paid; set => paid = value; }

        public override string ToString()
        {
            return $"{bill_ID}-{table_ID}-{total_Price}-{date_And_Time}";
        }
    }
}
