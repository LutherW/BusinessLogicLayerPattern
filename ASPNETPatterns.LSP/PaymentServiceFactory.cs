using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.LSP
{
    public class PaymentServiceFactory
    {
        public static PaymentServiceBase GetPaymentServiceFrom(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.PayPal:
                    return new PayPalPayment("user", "password");
                case PaymentType.WorldPay:
                    return new WorldPayPayment("accountId", "accountPassword", "1");
                default:
                    throw new ApplicationException("无效的支付类型");
            }
        }
    }
}
