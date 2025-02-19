using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class item : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            grid_view();
        }

    }
    protected void btnsumit_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into item values('" + txtiname.Text + "','" + txtprice.Text + "','" + txtqty.Text + "')", conn);
            int t = cmd.ExecuteNonQuery();
            if (t > 0)
            {
                Response.Write("<script>alert('data has been submitted successfully')</script>");
                clear();
            }

            conn.Close();
        }
    }

    public void clear()
    {
        txtiname.Text = "";
        txtprice.Text = "";
        txtqty.Text = "";
    }
    public void grid_view()
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from item", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            conn.Close();
        }


    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        grid_view();


    }


    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            Response.Write(id);
            string iname = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string iprice = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string iqty = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("update item set iname='" + iname + "',price='" + iprice + "',qty='" + iqty + "'where Item_id='" + id + "' ", conn);
            int t = cmd.ExecuteNonQuery();
            conn.Close();

            if (t > 0)
            {
                Response.Write("<script>alert('data has been updated')</script>");

                GridView1.EditIndex = -1;
                grid_view();
            }
        }    



    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            Response.Write(id);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from item where Item_id='" + id + "'", conn);
            int t = cmd.ExecuteNonQuery();
            conn.Close();

            if (t > 0)
            {
                Response.Write("<script>alert('data has been deleted')</script>");

                GridView1.EditIndex = -1;
                grid_view();
            }
        }

    }
}