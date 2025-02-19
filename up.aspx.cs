using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Viewitems : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\kheni\OneDrive\Desktop\login page\App_Data\Database.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getData();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void Gridview1_editing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        getData();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        getData();
    }

    public void getData()
    {
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from lib", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = GridView1.Rows[e.RowIndex];
            TextBox txtIname = row.Cells[1].Controls[0] as TextBox;
            TextBox txtIprice = row.Cells[2].Controls[0] as TextBox;

            if (txtIname == null || txtIprice == null)
            {
                Response.Write("<script>alert('One or more TextBox controls not found.')</script>");
                return;
            }

            string iname = txtIname.Text;
            string iprice = txtIprice.Text;

            cn.Open();
            string query = "UPDATE lib SET item_name=@iname, item_price=@iprice WHERE item_id=@id";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@iname", iname);
            cmd.Parameters.AddWithValue("@iprice", iprice);

            int t = cmd.ExecuteNonQuery();
            cn.Close();

            if (t > 0)
            {
                Response.Write("<script>alert('Data has been updated')</script>");
                GridView1.EditIndex = -1;
                getData();
            }
            else
            {
                Response.Write("<script>alert('No rows were updated.')</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('An error occurred: " + ex.Message + "')</script>");
        }
        finally
        {
            cn.Close();
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        try
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = GridView1.Rows[e.RowIndex];
       
            cn.Open();
            string query = "delete from lib  WHERE item_id=@id";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", id);
            
            int t = cmd.ExecuteNonQuery();
            cn.Close();

            if (t > 0)
            {
                Response.Write("<script>alert('Data has been deleted')</script>");
                GridView1.EditIndex = -1;
                getData();
            }
        
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('An error occurred: " + ex.Message + "')</script>");
        }
        finally
        {
            cn.Close();
        }
    }
}
