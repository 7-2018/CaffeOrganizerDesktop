using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Web.UI.HtmlControls;

namespace CaffeOrganizerWeb
{
    public partial class Bill : System.Web.UI.Page
    {
        List<CaffeBillItem> cb;
        BillBusiness br;


        protected void Page_Load(object sender, EventArgs e)
        {
            naslov.InnerText = "RAČUN ZA STO BROJ " + TableBusiness.curentTable.Table_ID;
            naslov.Style.Add("color", "#a37417");
            naslov.Style.Add("font-size", "3.5rem");
            naslov.Style.Add("font-family", "times new roman");
            Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price.ToString()+" RSD";
           
            ArticleBusiness ab = new ArticleBusiness();
            BillItemRepository bib = new BillItemRepository();
            BillBusiness br = new BillBusiness();
            cb = bib.GetCaffeBillItems().Where(x => x.Bill_ID == br.GetCaffeBill.Bill_ID).ToList();
           
            foreach(CaffeBillItem c in cb)
            {
                HtmlGenericControl par = new HtmlGenericControl("p");
                par.Style.Add("font-size", "1.3rem");
                par.Style.Add("font-family", "Times New Roman");
                par.InnerText = ab.GetCaffeArticles().Where(x => x.Article_ID == c.Article_ID).ToList()[0].ToString();
                contentmain.Controls.Add(par);
            }
        }

      

        protected void dodaj_ServerClick(object sender, EventArgs e)
        {
            ArticleBusiness ab = new ArticleBusiness();
            BillItemRepository billItem = new BillItemRepository();
            BillBusiness bp = new BillBusiness();
            String s = toplinapici.Value;
            if (s != null && s!= "Topli napici")
            {
                CaffeArticle c = ab.GetCaffeArticles().Where(x => x.Name.Equals(s)).ToList()[0];
                BillBusiness.currentBill.Total_Price += c.Price;
                HtmlGenericControl par = new HtmlGenericControl("p");
                par.InnerText = c.ToString();
               // contentmain.Controls.Add(par);
                BillItemRepository br = new BillItemRepository();
                 billItem.InsertCaffeBillItem(new CaffeBillItem(c.Article_ID, BillBusiness.currentBill.Bill_ID, 1));
                Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price+" RSD";
                bp.UpdateCaffeBill(BillBusiness.currentBill);
                Response.Redirect("Bill.aspx");
            }
        }

        protected void Button3_ServerClick(object sender, EventArgs e)
        {
            TableBusiness tb = new TableBusiness();
            BillBusiness bb = new BillBusiness();
            TableBusiness.curentTable.Taken = false;
            tb.UpdateTable(TableBusiness.curentTable);
            BillBusiness.currentBill.Paid = true;
            bb.UpdateCaffeBill(BillBusiness.currentBill);
            BillBusiness.currentBill = null;
            Response.Redirect("Home.aspx");

        }
    }
}