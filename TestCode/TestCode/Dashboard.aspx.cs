﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["EmailAddress"] = this.lblEmailAddress.Text;
        if (Session["Email"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        lblEmailAddress.Text = Session["Email"].ToString();
        
    }
}