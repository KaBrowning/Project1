using System;
using System.Web.UI;
using App_Code;

public partial class CustomerList : Page
{
    private Customer _selectedCustomer;

    protected void Page_Load(object sender, EventArgs e)
    {
       // if (!IsPostBack)
        //{
        this._selectedCustomer = new Customer();
        // = this.GetSelectedCustomer();
        //this._selectedCustomer = (Customer) Session["Customer"];
        //  }


    }

    //private Customer GetSelectedCustomer()
    //{
        //Customer customer = new Customer();
       // DataView customerTableView = (DataView) this.SqlDataSource.Select(DataSourceSelectArguments.Empty);
       // if (customerTableView != null)
       // {
       //     customerTableView.RowFilter = string.Format("CustomerID = '{0}'", this.ddlCustomers.SelectedValue);
       //     DataRowView row = (DataRowView) customerTableView[0];
            
       //     customer.CustumerId = row["CustomerId"].ToString();
        //    customer.Name = row["Name"].ToString();
        //    customer.Address = row["Address"].ToString();
        //    customer.City = row["City"].ToString();
        //    customer.State = row["State"].ToString();
       //     customer.Zipcode = row["Zipcode"].ToString();
        //    customer.Phone = row["Phone"].ToString();
        //    customer.Email = row["Email"].ToString();        
      //  }
       // return customer;
   // }

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
      //  this.ddlCustomers.SelectedValue = this._customer.CustumerId;

        App_Code.CustomerList customerList = App_Code.CustomerList.GetCustomers(); //get CustomerList from session state
        Customer aCustomer = customerList[this._selectedCustomer.CustumerId]; 
        //Does the item already exist? uses indexer of CustomerList object to get the customer object with customer ID of the customer

        if (aCustomer == null) 
        {
            customerList.AddItem(this._selectedCustomer);
        }
        //if item isn't found with customer ID, addItem is used to add an item with the selected ID to the list.

        this.lblSuccessfulAdd.Text = "Customer added successfully.";
    }

    protected void btnViewList_Click(object sender, EventArgs e)
    {
        Response.Redirect("contactlist.aspx");
    }
}