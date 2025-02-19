using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class loglib : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\kheni\OneDrive\Desktop\login page\App_Data\Database.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select username,password from reg where username ='" + TextBox1.Text + "' and password ='" + TextBox2.Text + "'", cn);
        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["id"] = TextBox1.Text;
            Response.Redirect("insert.aspx");
        }
        else
        {
            errorMSG.Text = "INVALID ID or PASSWORD";
            errorMSG.ForeColor = System.Drawing.Color.Red;
            cn.Close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("registration.aspx");
    }
}