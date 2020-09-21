using DependencyInjection;
using DependencyInjection.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Commerce
    {
        public Commerce(IBillingProcessor billingProcessor, ICustomer customer, INotifier notifier, ILogger logger)
        {
            _billingProcessor = billingProcessor;
            _customer = customer;
            _notifier = notifier;
            _logger = logger;
        }

        IBillingProcessor _billingProcessor;
        ICustomer _customer;
        INotifier _notifier;
        ILogger _logger;

        public void ProcessOrder(OrderInfo orderInfo)
        {
            _billingProcessor.PaymentProcess(orderInfo.EmployeeName, orderInfo.EmployeeID, orderInfo.EmployeeSalary);
        }

    }
}
