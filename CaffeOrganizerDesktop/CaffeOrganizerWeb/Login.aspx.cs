﻿using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaffeOrganizerWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_ServerClick(object sender, EventArgs e)
        {
            WorkerBusiness wr = new WorkerBusiness();
            foreach(CaffeWorker caffeWorker in wr.GetCaffeWorkers())
            {
                if (txtuser.Value.Equals(caffeWorker.User_Name) && txtpass.Value.Equals(caffeWorker.Password))
                {
                    wr.getsetworker = caffeWorker;
                    Response.Redirect("Home.aspx");
                }
                else
                    Label1.Visible = true;
            }
            
        }
    }
}