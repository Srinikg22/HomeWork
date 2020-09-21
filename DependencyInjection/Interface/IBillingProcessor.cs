using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Interface
{
    interface IBillingProcessor
    {
        void PaymentProcess(string customer, int CreditCard, int price);
    }
}
