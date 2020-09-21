using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Interface
{
    interface ICustomer
    {
        void UpdateCustomerOrder(string customer, string product);
    }
}
