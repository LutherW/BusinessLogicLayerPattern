using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.LSP
{
    public class PayPalPayment : PaymentServiceBase
    {
        public PayPalPayment(string accountName, string password) 
        {
            this.AccountName = accountName;
            this.Password = password;
        }

        public string AccountName { get; set; }
        public string Password { get; set; }

        public override RefundResponse Refund(decimal amount, string transactionId)
        {
            RefundResponse refundResponse = new RefundResponse();
            MockPayPalWebService service = new MockPayPalWebService();
            string token = service.ObtainToken(AccountName, Password);
            string response = service.MakeRefund(amount, transactionId, token);
            refundResponse.Message = response;
            refundResponse.Success = response.Contains("A_Success");

            return refundResponse;
        }
    }
}
