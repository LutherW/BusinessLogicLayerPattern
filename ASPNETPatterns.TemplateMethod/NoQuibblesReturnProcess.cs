using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.TemplateMethod
{
    public class NoQuibblesReturnProcess :  ReturnProcessTemplate
    {
        public override void GenerateReturnTransactionFor(ReturnOrder order)
        {
            throw new NotImplementedException();
        }

        public override void CalculateReturnFor(ReturnOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
