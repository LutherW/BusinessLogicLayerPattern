using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.LSP
{
    public class RefundService
    {
        public RefundResponse Refund(RefundRequest refundRequest) 
        {
            PaymentServiceBase payment = PaymentServiceFactory.GetPaymentServiceFrom(refundRequest.Payment);
            RefundResponse response = payment.Refund(refundRequest.RefundAmount, refundRequest.PaymentTransactionId);

            return response;
        }
    }
}
