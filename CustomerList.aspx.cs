using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;

public partial class CustomerList : Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void btnAddToContacts_Click(object sender, EventArgs e)
    {
        ListBox customerListBox = new ListBox();
        customerListBox.Items.Add(new ListItem(this.ddlCustomers.SelectedItem.Text, this.ddlCustomers.SelectedItem.Value));
        this.lblSuccessfulAdd.Text = "Customer added successfully.";
    }

    protected void btnViewList_Click(object sender, EventArgs e)
    {
        Response.Redirect("contactlist.aspx");
    }
}