using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] != null) // Check if the user is logged in
        {
        //    // Hide the Register and Login links
            RegisterLink.Visible = false;
           string user = Session["id"].ToString();
           lblWelcome.Text = "Welcome      :  " + user;
        //    // Show the Logout link
            LogoutLink.Visible = true;
        }
        else
        {
        //    // Show the Register and Login links
           RegisterLink.Visible = true;
            

        //    // Hide the Logout link
            LogoutLink.Visible = false;
        }
    }

    protected void LogoutLink_Click(object sender, EventArgs e)
    {
        // Clear the session and redirect to the home page
        Session.Clear();
        Response.Redirect("login.aspx");
    
    }
}
