using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.TemplateMethod
{
    public class ReturnService
    {
        public void Process(ReturnOrder order) 
        {
            ReturnProcessTemplate returnProcess = ReturnProcessFactory.CreateFrom(order);
            returnProcess.Process(order);
        }
    }
}
