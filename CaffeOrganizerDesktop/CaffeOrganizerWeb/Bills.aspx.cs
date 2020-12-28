using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaffeOrganizerWeb
{
    public partial class Bills : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            curworker.InnerText = WorkerBusiness.currentWoker.User_Name;
            BillBusiness bb = new BillBusiness();
            Table t = new Table();
            TableRow r1 = new TableRow();
            TableCell c1 = new TableCell();
            c1.Text = "BILL ID";
            r1.Cells.Add(c1);
            TableCell c2 = new TableCell();
            c2.Text = "TABLE ID";
            r1.Cells.Add(c2);
            TableCell c3 = new TableCell();
            c3.Text = "TOTAL PRICE";
            r1.Cells.Add(c3);
            TableCell c4 = new TableCell();
            c4.Text = "DATE";
            r1.Cells.Add(c4);
            t.Rows.Add(r1);

            foreach (CaffeBill cb in bb.getCaffeBills())
            {
                if (cb.Total_Price != 0 && cb.Date_And_Time.Day == DateTime.Today.Day && cb.Date_And_Time.Month == DateTime.Today.Month && cb.Date_And_Time.Year == DateTime.Today.Year)
                {
                    TableRow r1t = new TableRow();
                    TableCell c1t = new TableCell();
                    c1t.Text = cb.Bill_ID.ToString();
                    r1t.Cells.Add(c1t);
                    TableCell c2t = new TableCell();
                    c2t.Text = cb.Table_ID.ToString();
                    r1t.Cells.Add(c2t);
                    TableCell c3t = new TableCell();
                    c3t.Text = cb.Total_Price.ToString();
                    r1t.Cells.Add(c3t);
                    TableCell c4t = new TableCell();
                    c4t.Text = cb.Date_And_Time.ToString();
                    r1t.Cells.Add(c4t);
                    t.Rows.Add(r1t);
                }
            }
            t.Style.Add("font-size", "1.3rem");
            t.Style.Add("font-family", "Times New Roman");
            t.Attributes.Add("class", "table table-dark text-center");
            c2.Style.Add("color", "red");
            c1.Style.Add("color", "red");
            c3.Style.Add("color", "red");
            c4.Style.Add("color", "red");
            c1.Style.Add("font-weight", "700");
            c2.Style.Add("font-weight", "700");
            c3.Style.Add("font-weight", "700");
            c4.Style.Add("font-weight", "700");
            maindiv.Controls.Add(t);
        }
    }
}