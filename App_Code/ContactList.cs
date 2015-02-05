using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_Code
{

    /// <summary>
    /// Summary description for ContactList
    /// </summary>
    public class ContactList
    {
        private readonly CustomerList _customerList;

        public ContactList()
        {
            this._customerList = new CustomerList();
        }

        public void ViewContactList()
        {
            CustomerList.GetCustomers();
        }

        public void ClearList()
        {
            this._customerList.Clear();
        }

        //thought making this class would allow me to easily assign actions 
        //to the buttons in the aspx.cs class. Does not work like that. Seems as
        //if the aspx.cs class can't get any of the methods of this class.


    }
}