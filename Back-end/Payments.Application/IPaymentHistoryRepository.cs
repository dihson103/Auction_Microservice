using Payments.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application
{
    public interface IPaymentHistoryRepository
    {
        List<PaymentHistory> GetAllPaymentHistory();
        List<PaymentHistory> GetPaymentHistory(string userId);
        void AddPaymentHistory(PaymentHistory paymentHistory);
    }
}
