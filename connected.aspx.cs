using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class connected : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (var connection=new SqlConnection())
        {
            connection.ConnectionString = "Data Source=SQL5019.HostBuddy.com;Initial Catalog=DB_9D902A_wplproject;Persist Security Info=True;User ID=DB_9D902A_wplproject_admin;Password=asadmalik;";

            var command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "Insert into Information values ('"+txtName.Text+"','"+txtAddress.Text+"','"+txtCellNumber.Text+"','"+txtGender.Text+"','"+txtOccupation.Text+"')";

            connection.Open();
            command.ExecuteNonQuery();

            txtAddress.Text = txtCellNumber.Text = txtGender.Text = txtName.Text = txtOccupation.Text = "";
            Label1.Text = "Data Successfully Inserted";
        }
    }
}