using System;
using System.Activities.Debugger;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerList
/// </summary>
public class CustomerList
{
    private List<Customer> _customerList;
 
	public CustomerList()
	{
        this._customerList = new List<Customer>();
    }

    public Customer this[int index]
    {
        get { return this._customerList[index]; }
        set
        {
            Trace.Assert(true, "Invalid customer selection");
            this._customerList[index];
        }
    }

    public Customer this[String name]
    {
        get
        {
            if ()
            {
                
            }
         }
    }

    public int Count()
    {
        
    }

    public void AddItem(Customer newCustomer)
    {
        this._customerList.Add(newCustomer);
    }

    public void RemoveAt(int index)
    {
       this._customerList.RemoveAt(index);
    }

    public void Clear()
    {
        this._customerList.Clear();
    }

    public static CustomerList GetCustomers()
    {
        
    }

}