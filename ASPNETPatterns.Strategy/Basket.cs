using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Strategy
{
    public class Basket
    {
        private IBasketDiscountStrategy _basketDiscountStrategy;

        public Basket(DiscountType discountType) 
        {
            _basketDiscountStrategy = BasketDiscountFactory.GetDiscount(discountType);
        }

        public decimal TotalCost { get; set; }

        public decimal GetTotalCostAfterDiscount() 
        {
            return _basketDiscountStrategy.GetTotalCostAfterApplyingDiscountTo(this);
        }
    }
}
