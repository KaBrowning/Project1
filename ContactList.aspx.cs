using System;
using System.Web.UI;

public partial class ContactList : Page
{
    private ContactList _contactList;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CustomerList.GetCustomers();
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        if (!IsValid)
        {
            return;
        }
    }
}