using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Decorator
{
    public static class ProductCollectionExtensionMethods
    {
        public static void ApplyCurrencyMultiplier(this IEnumerable<Product> products) 
        {
            foreach (Product p in products)
            {
                p.Price = new CurrencyPriceDecorator(p.Price, 0.78M);
            }
        }

        public static void ApplyTradeDiscount(this IEnumerable<Product> products)
        {
            foreach (Product p in products)
            {
                p.Price = new TradeDiscountPriceDecorator(p.Price);
            }
        }
    }
}
