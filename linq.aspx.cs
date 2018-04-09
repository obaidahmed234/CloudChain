using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class linq : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            update();
        }
        Button2.Visible = false;
        Button3.Visible = false;

    }

    private void update()
    {
        LMSDataContext db = new LMSDataContext();

        var info = from b in db.Informations select b;

        GridView1.DataSource = info;
        GridView1.DataBind();

        ListBox1.DataSource = info;
        ListBox1.DataTextField = "Name";
        ListBox1.DataValueField = "Id";
        ListBox1.DataBind();

       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        LMSDataContext db = new LMSDataContext();

        Information info = new Information
            {
                Name=txtName.Text,
                Address=txtAddress.Text,
                CellNumber=txtCellNumber.Text,
                Gender=txtGender.Text,
                Occupation=txtOccupation.Text
            };
        db.Informations.InsertOnSubmit(info);
        db.SubmitChanges();

        txtAddress.Text = txtCellNumber.Text = txtGender.Text = txtName.Text = txtOccupation.Text = "";
        Label1.Text = "Data Successfully Inserted";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        LMSDataContext db = new LMSDataContext();

        int bkid = Convert.ToInt32(ListBox1.SelectedValue);

        var info = db.Informations.First(b => b.id == bkid);

        info.Name = txtName.Text;
        info.Address = txtAddress.Text;
        info.CellNumber = txtCellNumber.Text;
        info.Gender = txtName.Text;
        info.Occupation = txtOccupation.Text;

        db.SubmitChanges();
        update();
        Label1.Text = "Data Successfully Updated";
        Button1.Visible = true;
        Button2.Visible = false;

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        LMSDataContext db = new LMSDataContext();

        int bkid = Convert.ToInt32(ListBox1.SelectedValue);

        var info = db.Informations.First(b => b.id == bkid);

        txtAddress.Text = info.Address;
        txtCellNumber.Text = info.CellNumber;
        txtGender.Text = info.Gender;
        txtName.Text = info.Name;
        txtOccupation.Text = info.Occupation;

        Button1.Visible = false;
        Button2.Visible = true;
        Button3.Visible = true;

    }
}