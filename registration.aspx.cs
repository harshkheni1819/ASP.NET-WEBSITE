using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class registration : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\kheni\OneDrive\Desktop\login page\App_Data\Database.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string Username = TextBox1.Text;
            string Password = TextBox2.Text;

            // Open connection
            cn.Open();

            // Create query to insert new user
            string qry = "INSERT INTO reg (Username, first_name, last_name, email, Password, state, city, confirm_password, phone_no) VALUES (@Username, @first_name, @last_name, @email, @Password, @state, @city, @confirm_password, @phone_no)";
             // Create SqlCommand and parameters
            using (SqlCommand cmd = new SqlCommand(qry, cn))
            {
                cmd.Parameters.AddWithValue("@Username", TextBox7.Text);
                cmd.Parameters.AddWithValue("@first_name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@last_name", TextBox8.Text);
                cmd.Parameters.AddWithValue("@email", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
                cmd.Parameters.AddWithValue("@state", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@city", DropDownList2.Text);
                cmd.Parameters.AddWithValue("@confirm_password", TextBox6.Text);
                cmd.Parameters.AddWithValue("@phone_no", TextBox11.Text);

                // Execute query
                int rowsAffected = cmd.ExecuteNonQuery();
                
                if (rowsAffected > 0)
                {
                    Response.Write("Registration Successful!");
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Response.Write("Registration Failed.");
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}