using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Models;
using System.Linq;

namespace CaffeOrganizer
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        

        private void Bill_Load(object sender, EventArgs e)
        {
            ArticleBusiness ab = new ArticleBusiness();
            BillItemBusiness bib = new BillItemBusiness();
         
            foreach(CaffeBillItem b in bib.GetCaffeBillItems())
            {
                if (b.Bill_ID == BillBusiness.currentBill.Bill_ID)
                {
                    CaffeArticle temp = ab.GetCaffeArticles().Where(x => x.Article_ID == b.Article_ID).ToList()[0];
                    listBox1.Items.Add(temp.ToString() + " " +  b.Quantity);
                }
            }
            textBox1.Text = BillBusiness.currentBill.Total_Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
