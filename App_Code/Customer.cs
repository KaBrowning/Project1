using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    private string _customerID;
    private string _name;
    private string _address;
    private string _city;
    private string _state;
    private string _zipcode;
    private string _phone;
    private string _email;

    public string CostumerId
    {
        get {return this._customerID}
        set
        {
            Trace.Assert(value != null, "Invalid Customer ID");
            this._customerID = value;
        }
    }

    public string Name
    {
        get { return this._name; }
        set
        {
            Trace.Assert(value != null, "Invalid Customer Name");
            this._name = value;
        }
    }

    public string Address
    {
        get { return this._address; }
        set
        {
            Trace.Assert(value != null, "Invalid Customer Address");
            this._address = value;
        }
    }

    public string City
    {
        get { return this._city; }
        set
        {
            Trace.Assert(value != null, "Invalid Customer City");
            this._city = value;
        }

    }
}