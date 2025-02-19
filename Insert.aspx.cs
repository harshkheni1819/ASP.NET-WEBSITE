using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Insert : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\kheni\OneDrive\Desktop\login page\App_Data\Database.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
          
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            cn.Open();
            string path;
            if (FileUpload1.HasFile)
                FileUpload1.SaveAs(HttpContext.Current.Request.PhysicalApplicationPath + "image/" + FileUpload1.FileName);

            path = FileUpload1.FileName;
            string qry = "INSERT INTO lib ( Book_Name, Quantity, Price, Author_Name, Image) VALUES ( @Book_Name, @Quantity, @Price, @Author_Name, @Image)";
            // Create SqlCommand and parameters
            using (SqlCommand cmd = new SqlCommand(qry, cn))
            {
                
                cmd.Parameters.AddWithValue("@Book_Name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Quantity", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Price", TextBox4.Text);             
                cmd.Parameters.AddWithValue("@Author_Name", TextBox5.Text);
                cmd.Parameters.AddWithValue("@Image", FileUpload1.FileName);
                

                // Execute query

                int t = cmd.ExecuteNonQuery();

                if (t > 0)
                {
                    Response.Write("Successful!");
                }
                else
                {
                    Response.Write("Failed.");
                }
            }
        }
        catch (Exception ex)
        {
            // Log exception (ex) if needed and show user-friendly message
            Response.Write("Error occurred: " + ex.Message);
        }
        finally
        {
            // Ensure connection is closed
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridView1.DataBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
        string qty = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
        string price = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
        string A_N = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
        cn.Open();
        SqlCommand cmd = new SqlCommand("update lib  set Book_Name='" + name + "',Quantity='" + qty + "',Price='" + price + "',Author_Name='" + A_N + "' where Book_ID ='" + id + "'",cn);
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
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

        
    
