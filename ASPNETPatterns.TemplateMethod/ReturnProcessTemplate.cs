using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.TemplateMethod
{
    public abstract class ReturnProcessTemplate
    {
        public abstract void GenerateReturnTransactionFor(ReturnOrder order);
        public abstract void CalculateReturnFor(ReturnOrder order);

        public void Process(ReturnOrder order) 
        {
            GenerateReturnTransactionFor(order);
            CalculateReturnFor(order);
        }
    }
}
