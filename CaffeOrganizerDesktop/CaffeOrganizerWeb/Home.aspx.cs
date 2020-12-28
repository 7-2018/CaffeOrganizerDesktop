using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CaffeOrganizerWeb
{
    public partial class Home : System.Web.UI.Page
    {
        public HtmlGenericControl column;
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 1;
            
            TableBusiness tb = new TableBusiness();
            foreach (CaffeTable c in tb.getCaffeTables())
            {
               column  = new HtmlGenericControl("div");
                column.Attributes.Add("class", "col-3 text-center");
                Button b = new Button();
                b.Text = "View Bill";
                b.Click += B_Click;
                b.ID = c.Table_ID.ToString();
                b.Attributes.Add("class", "btn btn-outline-danger");
                b.CommandArgument = i.ToString();
                Button b1 = new Button();
                b1.Text = "Ocuppy";
                b1.Click += B1_Click;
                b1.ID = (c.Table_ID+99).ToString();
                b1.CommandArgument = i.ToString();
                b1.Attributes.Add("class", "btn btn-outline-success");
                if (c.Taken)
                {

                    column.InnerHtml += $"<p  style='background:red;border-radius: 0.5rem'>Table: {i} <br><i class='fa fa-coffee fa-3x' aria-hidden='true'></i><br> Seats: {c.Number_Of_Seats}<p>";
                    column.Controls.Add(b);
                }
                else
                {
                    column.InnerHtml += $"<p style='background:green;border-radius: 0.5rem'>Table: {i} <br><i class='fa fa-coffee fa-3x' aria-hidden='true'></i><br> Seats: {c.Number_Of_Seats}<p>";
                    column.Controls.Add(b1);
                }
                maindiv.Controls.Add(column);
                i++;

            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();

            Button b1 = sender as Button;
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == (Convert.ToInt32(b1.ID)-99)).ToList()[0];
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, (Convert.ToInt32(b1.ID) - 99), 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            b11.InsertCaffeBill(BillBusiness.currentBill);
            t.Table_ID = Convert.ToInt32(b1.CommandArgument);
            TableBusiness.curentTable = t;
            Response.Redirect("Bill.aspx");
            
        }

        private void B_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();

            Button b1 = sender as Button;
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == (Convert.ToInt32(b1.ID))).ToList()[0];
            tb.UpdateTable(t);
           
            
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            
            t.Table_ID = Convert.ToInt32(b1.CommandArgument);
            TableBusiness.curentTable = t;
            Response.Redirect("Bill.aspx");
        }
    }
}