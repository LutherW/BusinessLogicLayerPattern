﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.LSP
{
    public class RefundRequest
    {
        public PaymentType Payment { get; set; }
        public string PaymentTransactionId { get; set; }
        public decimal RefundAmount { get; set; }
    }
}
