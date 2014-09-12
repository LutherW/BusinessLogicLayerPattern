using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Decorator
{
    public class BasePrice : IPrice
    {
        private decimal _price;

        public decimal Cost
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
}
