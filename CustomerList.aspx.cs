using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;

public partial class CustomerList : Page
{
    private Customer _customer;

    protected void Page_Load(object sender, EventArgs e)
    {
      //  if (!IsPostBack)
        //{
            //this._customer = (Customer) Session["Customer"];
        //}

        this._customer = new Customer();
    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void btnAddToContacts_Click(object sender, EventArgs e)
    {
     //  var customerList = new App_Code.CustomerList();
     //  var aCustomer = new Customer()
     //  {
      //     CustumerId = 
      //  }
 
        //find a way to assign the customer to the ddl selected index value
       //customerList.AddItem(aCustomer);


        this.ddlCustomers.SelectedValue = this._customer.CustumerId;
        this.lblSuccessfulAdd.Text = "Customer added successfully.";
    }

    protected void btnViewList_Click(object sender, EventArgs e)
    {
        Response.Redirect("contactlist.aspx");
    }
}