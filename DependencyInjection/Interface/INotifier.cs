using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Interface
{
    interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
