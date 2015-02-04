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

    /// <summary>
    /// Adds a customer to the list.
    /// </summary>
    /// <param name="newCustomer">The new customer.</param>
    public void AddItem(Customer newCustomer)
    {
        this._customerList.Add(newCustomer);
    }

    /// <summary>
    /// Removes customer at specified index.
    /// </summary>
    /// <param name="index">The index.</param>
    public void RemoveAt(int index)
    {
       this._customerList.RemoveAt(index);
    }

    /// <summary>
    /// Clears this list of customers.
    /// </summary>
    public void Clear()
    {
        this._customerList.Clear();
    }

    public static CustomerList GetCustomers()
    {
        
    }

}