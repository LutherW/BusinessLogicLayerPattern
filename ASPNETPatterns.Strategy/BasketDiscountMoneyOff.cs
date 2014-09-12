using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Strategy
{
    public class BasketDiscountMoneyOff : IBasketDiscountStrategy
    {
        public decimal GetTotalCostAfterApplyingDiscountTo(Basket basket)
        {
            if (basket.TotalCost > 100M) 
            {
                return basket.TotalCost -= 10M;
            }
            else if (basket.TotalCost > 50M)
            {
                return basket.TotalCost -= 5M;
            }
            else 
            {
                return basket.TotalCost;
            }
        }
    }
}
