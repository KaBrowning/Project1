using System;
using System.Web;
using System.Web.UI;

public partial class CustomerList : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Gets the list of customers.
    /// </summary>
    /// <returns></returns>
    public static CustomerList GetCustomers()
    {
        var cList = (CustomerList)HttpContext.Current.Session["Customer"];
        if (cList == null)
            HttpContext.Current.Session["Customer"] = new CustomerList();
        return (CustomerList)HttpContext.Current.Session["Customer"];
    }

}