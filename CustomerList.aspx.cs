using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
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

    }
    protected void btnViewList_Click(object sender, EventArgs e)
    {
        Response.Redirect("contactlist.aspx");
    }
}