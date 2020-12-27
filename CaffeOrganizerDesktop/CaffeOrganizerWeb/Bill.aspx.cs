using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace CaffeOrganizerWeb
{
    public partial class Bill : System.Web.UI.Page
    {
        List<CaffeBillItem> cb;
        BillBusiness br;


        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price.ToString();
            ListBox1.Items.Clear();
            ArticleBusiness ab = new ArticleBusiness();
            BillItemRepository bib = new BillItemRepository();
            BillBusiness br = new BillBusiness();
            cb = bib.GetCaffeBillItems().Where(x => x.Bill_ID == br.GetCaffeBill.Bill_ID).ToList();
            
            foreach(CaffeBillItem c in cb)
            {
                ListBox1.Items.Add(ab.GetCaffeArticles().Where(x => x.Article_ID == c.Article_ID).ToList()[0].ToString());
            }
        }

        protected void Pica_ServerClick(object sender, EventArgs e)
        {
            
            ArticleBusiness ab = new ArticleBusiness();
            List<CaffeArticle> gazirana = ab.GetCaffeArticles().Where(x => x.Packaging == "Gazirana Pica").ToList();

            foreach (CaffeArticle p in gazirana)
                ListBox2.Items.Add(p.ToString());
        }

        protected void dodaj_ServerClick(object sender, EventArgs e)
        {
            BillItemRepository billItem = new BillItemRepository();
            BillBusiness bp = new BillBusiness();
            String s = ListBox2.SelectedValue;
            if (s != null)
            {
                string[] cenas = s.Split('-');
              BillBusiness.currentBill.Total_Price  += Convert.ToInt32(cenas[2]);

                ListBox1.Items.Add(s);
                BillItemRepository br = new BillItemRepository();
                 billItem.InsertCaffeBillItem(new CaffeBillItem(Convert.ToInt32(cenas[0]), BillBusiness.currentBill.Bill_ID, 1));
                Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price;
                bp.UpdateCaffeBill(BillBusiness.currentBill);
            }
        }
    }
}