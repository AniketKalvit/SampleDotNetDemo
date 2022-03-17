using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    public interface ICustomer
    {
        string DisplayDetails();
    }

    public interface IOrder
    {
        string DisplayDetails();
    }
    public class Transaction : ICustomer, IOrder
    {
        string ICustomer.DisplayDetails()
        {
            return "Customer details";
        }

        string IOrder.DisplayDetails()
        {
            return "Order details";
        }
    }
}
