using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;


public partial class ContactList : Page
{
    private App_Code.CustomerList _customerList;

    protected void Page_Load(object sender, EventArgs e)
    {
        this._customerList = new App_Code.CustomerList();

        if (!IsPostBack)
        {
            //return;


            this.lbCurrentCustomerList.DataSource = "SqlDataSourceSelectedItem"; //set the data source

            Session["Customer"] = this.lbCurrentCustomerList;
            foreach (ListItem customer in ((ListBox) (Session["Customer"])).Items)
            {
                this.lbCurrentCustomerList.Items.Add(new ListItem(Items.ToString(), Items.Values.ToString()));
            }
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
       // var aCustomer = new CustomerList();
       // aCustomer.Clear();
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {

        this._customerList.RemoveAt(this.lbCurrentCustomerList.SelectedIndex);
    }

    protected void btnSelectMore_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}