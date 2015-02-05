using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;


public partial class ContactList : Page
{
    private CustomerList _customerList;

    protected void Page_Load(object sender, EventArgs e)
    {
        this._customerList = new CustomerList();

        if (!IsPostBack)
        {
            return;
        }
        //  this.lbCurrentCustomerList.Items.Add(new ListItem(App_Code.CustomerList.GetCustomers().ToString()));
            Session["Customer"] = this.lbCurrentCustomerList;
            foreach(ListItem customer in ((ListBox)(Session["Customer"])).Items)
            {
                this.lbCurrentCustomerList.Items.Add(new ListItem(Items.ToString(), Items.Values.ToString()));
            }
       
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        if (!IsValid)
        {
            return;
        }
       // var aCustomer = new CustomerList();
       // aCustomer.Clear();
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        if (!IsValid)
        {
            return;
        }
    }

    protected void btnSelectMore_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}