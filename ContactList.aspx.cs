using System;
using System.Web.UI;
using App_Code;


public partial class ContactList : Page
{
    private CustomerList _customerList;

    protected void Page_Load(object sender, EventArgs e)
    {
        this._customerList = new CustomerList();

        if (!IsPostBack)
        {
            App_Code.CustomerList.GetCustomers();
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        if (!IsValid)
        {
            return;
        }
        App_Code.CustomerList aCustomer = new CustomerList();
        aCustomer.Clear();
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        if (!IsValid)
        {
            return;
        }
    }
}