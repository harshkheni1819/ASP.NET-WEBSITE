using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class view : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\kheni\OneDrive\Desktop\login page\App_Data\Database.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void grid_view()
    {
        throw new NotImplementedException();
        cn.Open();
        string qry = "select * from lib";
        using (SqlCommand cmd = new SqlCommand(qry, cn))
        {
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        cn.Close();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
        string qty = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
        string price = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
        string A_N = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
        cn.Open();
        SqlCommand cmd = new SqlCommand("update lib  set Book_Name='" + name + "',Quantity='" + qty + "',Price='" + price + "',Author_Name='" + A_N + "' where Book_ID ='" + id + "'", cn);
        int rowsAffected = cmd.ExecuteNonQuery();
        if (rowsAffected > 0)
        {
            Response.Write("<script>alert('data has been updated')</script>");
            GridView1.EditIndex = -1;
            GridView1.DataBind();
        }
        cn.Close();
            
        
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        

    }
    protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        Response.Write(id);
        cn.Open();
        SqlCommand cmd = new SqlCommand("delete from lib where Book_ID='" + id + "'", cn);
        int t = cmd.ExecuteNonQuery();


        if (t > 0)
        {
            Response.Write("<script>alert('data has been deleted')</script>");

            GridView1.EditIndex = -1;
            GridView1.DataBind();
        }
        cn.Close();
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)           
    {
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from lib", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
        
        cn.Close();
        
    }
}