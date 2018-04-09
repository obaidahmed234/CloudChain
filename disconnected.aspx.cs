using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class disconnected : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            UpdateGrid();
    }

    private void UpdateGrid()
    {
        try
        {
            var connection = new SqlConnection("Data Source=SQL5019.HostBuddy.com;Initial Catalog=DB_9D902A_wplproject;Persist Security Info=True;User ID=DB_9D902A_wplproject_admin;Password=asadmalik;");
            var data = new DataSet();
            var adapter = new SqlDataAdapter("Select * from Information", connection);
            var build = new SqlCommandBuilder(adapter);

            adapter.Fill(data, "Information");


            GridView1.DataSource = data.Tables["Information"];
            GridView1.DataBind();

            ListBox1.DataSource = data.Tables["Information"];
            ListBox1.DataTextField = "Name";
            ListBox1.DataValueField = "Id";
            ListBox1.DataBind();

            Button2.Visible = false;
            Button3.Visible = false;
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            var connection = new SqlConnection("Data Source=SQL5019.HostBuddy.com;Initial Catalog=DB_9D902A_wplproject;Persist Security Info=True;User ID=DB_9D902A_wplproject_admin;Password=asadmalik;");
            var data = new DataSet();
            var adapter = new SqlDataAdapter("Select * from Information", connection);
            var build = new SqlCommandBuilder(adapter);

            adapter.Fill(data, "Information");

            DataRow dr = data.Tables["Information"].NewRow();
            dr["Name"] = txtName.Text;
            dr["Address"] = txtAddress.Text;
            dr["CellNumber"] = txtCellNumber.Text;
            dr["Gender"] = txtGender.Text;
            dr["Occupation"] = txtOccupation.Text;
            data.Tables["Information"].Rows.Add(dr);

            adapter.Update(data, "Information");

            txtAddress.Text = txtCellNumber.Text = txtGender.Text = txtName.Text = txtOccupation.Text = "";
            Label1.Text = "Data Successfully Inserted";
            UpdateGrid();
        }
        catch(Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            var connection = new SqlConnection("Data Source=SQL5019.HostBuddy.com;Initial Catalog=DB_9D902A_wplproject;Persist Security Info=True;User ID=DB_9D902A_wplproject_admin;Password=asadmalik;");
            var data = new DataSet();
            var adapter = new SqlDataAdapter("Select * from Information", connection);
            var build = new SqlCommandBuilder(adapter);

            adapter.Fill(data, "Information");

            DataRow[] drr = data.Tables["Information"].Select("Id = " + ListBox1.SelectedValue);
            foreach (DataRow dr in drr)
            {
                txtName.Text = dr["Name"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtCellNumber.Text = dr["CellNumber"].ToString();
                txtGender.Text = dr["Gender"].ToString();
                txtOccupation.Text = dr["Occupation"].ToString();


            }

            Button1.Visible = false;
            Button2.Visible = true;
            Button3.Visible = true;
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            var connection = new SqlConnection("Data Source=SQL5019.HostBuddy.com;Initial Catalog=DB_9D902A_wplproject;Persist Security Info=True;User ID=DB_9D902A_wplproject_admin;Password=asadmalik;");
            var data = new DataSet();
            var adapter = new SqlDataAdapter("Select * from Information", connection);
            var build = new SqlCommandBuilder(adapter);

            adapter.Fill(data, "Information");

            DataRow[] drr = data.Tables["Information"].Select("Id = " + ListBox1.SelectedValue);
            foreach (DataRow dr in drr)
            {
                dr["Address"] = txtAddress.Text;
                dr["Name"] = txtName.Text;
            }

            adapter.Update(data, "Information");

            Button1.Visible = true;
            Button2.Visible = false;

            Label1.Text = "Data Successfully Updated";
            txtAddress.Text = txtCellNumber.Text = txtGender.Text = txtName.Text = txtOccupation.Text = "";
            UpdateGrid();
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            var connection = new SqlConnection("Data Source=SQL5019.HostBuddy.com;Initial Catalog=DB_9D902A_wplproject;Persist Security Info=True;User ID=DB_9D902A_wplproject_admin;Password=asadmalik;");
            var data = new DataSet();
            var adapter = new SqlDataAdapter("Select * from Information", connection);
            var build = new SqlCommandBuilder(adapter);

            adapter.Fill(data, "Information");

            DataRow[] drr = data.Tables["Information"].Select("Id = " + ListBox1.SelectedValue);
            foreach (DataRow dr in drr)
            {
                dr.Delete();
            }
            adapter.Update(data, "Information");

            Button1.Visible = true;
            Button2.Visible = false;
            Button3.Visible = false;

            Label1.Text = "Data Successfully Deleted";
            txtAddress.Text = txtCellNumber.Text = txtGender.Text = txtName.Text = txtOccupation.Text = "";
            UpdateGrid();
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
}