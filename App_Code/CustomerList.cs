using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
            value = this._customerList[index];
        }
    }

    /// <summary>
    /// Gets the <see cref="Customer"/> with the specified name.
    /// </summary>
    /// <value>
    /// The <see cref="Customer"/>.
    /// </value>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    public Customer this[String name]
    {
        get
        {
            foreach (Customer aCustomer in this._customerList)
            {
                if (aCustomer.Name == name)
                {
                    return aCustomer;
                }
            }
         }
    }

    /// <summary>
    /// Counts this instance.
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return this._customerList.Count;
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

    /// <summary>
    /// Gets the customers that are stored in the session state.
    /// </summary>
    /// <returns></returns>
    public static CustomerList GetCustomers()
    {
        if ( == null)
        {
            HttpContext.Current.Session["Customers"] = new Customer();
        }
        SortedList customers = (SortedList) HttpContext.Current.Session["Customers"];
    }

}