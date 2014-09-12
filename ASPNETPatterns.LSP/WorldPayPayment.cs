using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.LSP
{
    public class WorldPayPayment : PaymentServiceBase
    {
        public WorldPayPayment(string accountId, string accountPassword, string productId) 
        {
            this.AccountId = accountId;
            this.AccountPassword = accountPassword;
            this.ProductId = productId;
        }

        public string AccountId { get; set; }
        public string AccountPassword { get; set; }
        public string ProductId { get; set; }

        public override RefundResponse Refund(decimal amount, string transactionId)
        {
            RefundResponse refundResponse = new RefundResponse();
            MockWorldPayWebService service = new MockWorldPayWebService();
            string response = service.MakeRefund(amount, transactionId, AccountId, AccountPassword, ProductId);
            refundResponse.Message = response;
            refundResponse.Success = response.Contains("Auth");

            return refundResponse;
        }
    }
}
