using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;

public partial class CustomerList : Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
      //  SqlConnection connection = new SqlConnection(ConnectionStringSettingsCollection[0]);
       // SqlCommand command = new SqlCommand("select * from Customer where CustomerID=" + this.ddlCustomers.SelectedValue, connection);

       // connection.Open();
       // SqlDataReader reader = command.ExecuteReader();
//
      //  if (reader.Read())
      //  {
      //      this.lblPhone.Text = reader["Phone"].ToString();
      //  }

       // connection.Close();

        //App_Code.Customer c = from 
        
        //App_Code.CustomerList customers = new App_Code.CustomerList();
        //App_Code.Customer customer = customers[ddlCustomers.SelectedValue];

        //if (customer != null)
        //{
        //    this.lblPhone.Text = customer.Phone;


        //}

       //this.ddlCustomers.Items[0].Text = this.lblFirstName.Text;
        //this.lblLastName.Text = <%# Eval("CustomerID") %>;
       // this.lblAddress.Text = this.ddlCustomers.SelectedValue;
       // this.lblCity.Text = this.ddlCustomers.SelectedValue;
       // this.lblState.Text = this.ddlCustomers.SelectedValue;
       // this.lblZipcode.Text = this.ddlCustomers.SelectedValue;
        //this.lblPhone.Text = this.ddlCustomers.SelectedValue;
      //  this.lblEmail.Text = this.ddlCustomers.SelectedValue;
    }

    ///// <summary>
    ///// Gets the list of customers.
    ///// </summary>
    ///// <returns></returns>
    //public static CustomerList GetCustomers()
    //{
    //    var cList = (CustomerList)HttpContext.Current.Session["Customer"];
    //    if (cList == null)
    //        HttpContext.Current.Session["Customer"] = new CustomerList();
    //    return (CustomerList)HttpContext.Current.Session["Customer"];
    //}

}