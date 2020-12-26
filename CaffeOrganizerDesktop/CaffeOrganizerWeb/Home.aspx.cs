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
        protected void Page_Load(object sender, EventArgs e)
        {
            
            TableBusiness tb = new TableBusiness();
            foreach(CaffeTable c in tb.getCaffeTables())
            {
                HtmlGenericControl column = new HtmlGenericControl("div");
                column.Attributes.Add("class", "col-3 text-center");
              
                if (c.Taken)
                    column.InnerHtml += $"<p style='background:red'>{c.Table_ID} <br> {c.Number_Of_Seats}<p>";
                else
                    column.InnerHtml += $"<p style='background:green'>{c.Table_ID} <br> {c.Number_Of_Seats}<p>";
                maindiv.Controls.Add(column);
            }
        }
    }
}