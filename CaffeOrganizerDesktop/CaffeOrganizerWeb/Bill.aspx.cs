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
            naslov.InnerText = "RAČUN ZA STO BROJ ";
            radnik.InnerText = "Radnik: " + WorkerBusiness.currentWoker.User_Name;
            naslov.Style.Add("color", "#a37417");
            naslov.Style.Add("font-size", "3.5rem");
            naslov.Style.Add("font-family", "times new roman");
            naslov.InnerHtml += $"<span style='color:black;'> {TableBusiness.curentTable.Table_ID}</span>";
            Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price.ToString()+" RSD";
           
            ArticleRepository ab = new ArticleRepository();
            BillItemRepository bib = new BillItemRepository();
            BillBusiness br = new BillBusiness();
            cb = bib.GetCaffeBillItems().Where(x => x.Bill_ID == br.GetCaffeBill.Bill_ID).ToList();
           
            foreach(CaffeBillItem c in cb)
            {
                HtmlGenericControl par = new HtmlGenericControl("p");
                par.Style.Add("font-size", "1.3rem");
                par.Style.Add("font-family", "Times New Roman");
                par.InnerText = ab.GetCaffeArticles().Where(x => x.Article_ID == c.Article_ID).ToList()[0].ToString() + "   x"+c.Quantity;
                contentmain.Controls.Add(par);
            }
        }

      

        protected void dodaj_ServerClick(object sender, EventArgs e)
        {
            ArticleRepository ab = new ArticleRepository();
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
                try
                {
                    billItem.InsertCaffeBillItem(new CaffeBillItem(c.Article_ID, BillBusiness.currentBill.Bill_ID, 1));
                }
                catch(Exception xr)
                {
                    CaffeBillItem cs = cb.Where(x => x.Article_ID == c.Article_ID && x.Bill_ID == BillBusiness.currentBill.Bill_ID).ToList()[0];
                    cs.Quantity = cs.Quantity + 1;
                    billItem.UpdateBillItem(cs);

                }
                Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price+" RSD";
                bp.UpdateCaffeBill(BillBusiness.currentBill);
                
            }
            String s1 = zestina.Value;
            if (s1 != null && s1 != "Žestina")
            {
                CaffeArticle c = ab.GetCaffeArticles().Where(x => x.Name.Equals(s1)).ToList()[0];
                BillBusiness.currentBill.Total_Price += c.Price;
                HtmlGenericControl par = new HtmlGenericControl("p");
                par.InnerText = c.ToString();
                // contentmain.Controls.Add(par);
                BillItemRepository br = new BillItemRepository();
                try
                {
                    billItem.InsertCaffeBillItem(new CaffeBillItem(c.Article_ID, BillBusiness.currentBill.Bill_ID, 1));
                }
                catch (Exception xr)
                {
                    CaffeBillItem cs = cb.Where(x => x.Article_ID == c.Article_ID && x.Bill_ID == BillBusiness.currentBill.Bill_ID).ToList()[0];
                    cs.Quantity = cs.Quantity + 1;
                    billItem.UpdateBillItem(cs);

                }
                Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price + " RSD";
                bp.UpdateCaffeBill(BillBusiness.currentBill);
             
            }
            String s2 = Pivo.Value;
            if (s2 != null && s2 != "Pivo")
            {
                CaffeArticle c = ab.GetCaffeArticles().Where(x => x.Name.Equals(s2)).ToList()[0];
                BillBusiness.currentBill.Total_Price += c.Price;
                HtmlGenericControl par = new HtmlGenericControl("p");
                par.InnerText = c.ToString();
                // contentmain.Controls.Add(par);
                BillItemRepository br = new BillItemRepository();
                try
                {
                    billItem.InsertCaffeBillItem(new CaffeBillItem(c.Article_ID, BillBusiness.currentBill.Bill_ID, 1));
                }
                catch (Exception xr)
                {
                    CaffeBillItem cs = cb.Where(x => x.Article_ID == c.Article_ID && x.Bill_ID == BillBusiness.currentBill.Bill_ID).ToList()[0];
                    cs.Quantity = cs.Quantity + 1;
                    billItem.UpdateBillItem(cs);

                }
                Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price + " RSD";
                bp.UpdateCaffeBill(BillBusiness.currentBill);

            }
            String s3 = bezalkohola.Value;
            if (s3 != null && s3 != "Bezalkoholna pića")
            {
                CaffeArticle c = ab.GetCaffeArticles().Where(x => x.Name.Equals(s3)).ToList()[0];
                BillBusiness.currentBill.Total_Price += c.Price;
                HtmlGenericControl par = new HtmlGenericControl("p");
                par.InnerText = c.ToString();
                // contentmain.Controls.Add(par);
                BillItemRepository br = new BillItemRepository();
                try
                {
                    billItem.InsertCaffeBillItem(new CaffeBillItem(c.Article_ID, BillBusiness.currentBill.Bill_ID, 1));
                }
                catch (Exception xr)
                {
                    CaffeBillItem cs = cb.Where(x => x.Article_ID == c.Article_ID && x.Bill_ID == BillBusiness.currentBill.Bill_ID).ToList()[0];
                    cs.Quantity = cs.Quantity + 1;
                    billItem.UpdateBillItem(cs);

                }
                Label1.Text = "Total: " + BillBusiness.currentBill.Total_Price + " RSD";
                bp.UpdateCaffeBill(BillBusiness.currentBill);

            }
            Response.Redirect("Bill.aspx");
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

        protected void Button1_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}