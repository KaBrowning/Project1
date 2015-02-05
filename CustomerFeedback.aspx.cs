using System;
using System.Web.UI;

public partial class CustomerFeedback : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGoToFeedback_Click(object sender, EventArgs e)
    {
        if (!IsValid)
        {
            return;
        }

        this.lbFeedback.Focus();
    }
}