using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class loggggg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["id"] != null)
        //{
            
        //    string user = Session["id"].ToString();
        //    Label1.Text = "welcome     :    " + user;
           
        //}
        
    }
    protected void LogoutLink_Click(object sender, EventArgs e)
    {
        // Clear the session and redirect to the home page
        Session.Clear();
        Response.Redirect("Homee.aspx");

    }
}