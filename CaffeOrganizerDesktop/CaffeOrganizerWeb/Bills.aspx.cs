using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
            c1.Text = "BROJ RAČUNA";
            r1.Cells.Add(c1);
            TableCell c2 = new TableCell();
            c2.Text = "BROJ STOLA";
            r1.Cells.Add(c2);
            TableCell c3 = new TableCell();
            c3.Text = "UKUPNA CENA";
            r1.Cells.Add(c3);
            TableCell c4 = new TableCell();
            c4.Text = "DATUM";
            r1.Cells.Add(c4);
            t.Rows.Add(r1);
            int total = 0;
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
                    total += cb.Total_Price;
                }
            }
            t.Style.Add("font-size", "1.3rem");
            t.Style.Add("font-family", "Times New Roman");
            t.Attributes.Add("class", "table table-dark text-center");
            c2.Style.Add("color", "darkred");
            c1.Style.Add("color", "darkred");
            c3.Style.Add("color", "darkred");
            c4.Style.Add("color", "darkred");
            c1.Style.Add("font-weight", "700");
            c2.Style.Add("font-weight", "700");
            c3.Style.Add("font-weight", "700");
            c4.Style.Add("font-weight", "700");
            TableRow tr3 = new TableRow();
            TableCell tableCell = new TableCell();
            tableCell.Text = "Total: " + total + " RSD";
            tr3.Style.Add("font-weight", "700");
            tr3.Style.Add("color", "darkred");
            tr3.Cells.Add(tableCell);
            t.Rows.Add(tr3);
            maindiv.Controls.Add(t);
           
            
        }

        protected void buttonemail_ServerClick(object sender, EventArgs e)
        {
            String response;

            const string username = "elixrcaffenotifications@gmail.com";
            const string password = "martamladenovic";
            SmtpClient smtpclient = new SmtpClient();
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            //Set the email from address of mail message 
            MailAddress fromaddress = new MailAddress("elixrcaffenotifications@gmail.com");
            //Set the email smtp host
            smtpclient.Host = "smtp.gmail.com";
            //Set the email client port
            smtpclient.Port = 587;
            smtpclient.EnableSsl = true;
            mail.From = fromaddress;
            //Adding email id of receiver link
            mail.To.Add(emailtx.Value);
            //Set the email subject
            mail.Subject = ("Dnevni izvestaj");
            mail.IsBodyHtml = true;
            //Set the email body 
            StringWriter iSW = new StringWriter();
            HtmlTextWriter iHTW = new HtmlTextWriter(iSW);
            maindiv.RenderControl(iHTW);
            string iS = iSW.GetStringBuilder().ToString();
            mail.Body = "<div style='background:black'>"+iS+"</div>";
            smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpclient.Credentials = new System.Net.NetworkCredential(username, password);
            try
            {
                //Sending Email
                smtpclient.Send(mail);
                response = "Email Has been sent successfully.";
            }
            catch (Exception ex)
            {
                //Catch if any exception occurs
                response = ex.Message;
            }

           

        }


        
    }

}