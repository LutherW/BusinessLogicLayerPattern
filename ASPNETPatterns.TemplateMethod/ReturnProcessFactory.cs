using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.TemplateMethod
{
    public static class ReturnProcessFactory
    {
        public static ReturnProcessTemplate CreateFrom(ReturnOrder order) 
        {
            switch (order.Action)
            {
                case ReturnAction.FaultyReturn:
                    return new FaultyReturnProcess();
                case ReturnAction.NoQuibblesReturn:
                    return new NoQuibblesReturnProcess();
                default:
                    throw new ApplicationException("没有退货流程被定义");
            }
        }
    }
}
