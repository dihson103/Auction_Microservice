using Payments.Application;
using Payments.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Infrastructure
{
    public class PaymentHistoryRepository : IPaymentHistoryRepository
    {
        public void AddPaymentHistory(PaymentHistory paymentHistory)
        {
            throw new NotImplementedException();
        }

        public List<PaymentHistory> GetAllPaymentHistory()
        {
            throw new NotImplementedException();
        }

        public List<PaymentHistory> GetPaymentHistory(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
