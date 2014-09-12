using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Model
{
    public static class ShippingCourierFactory
    {
        public static IShippingCourier CreateShippingCourier(Order order) 
        {
            if (order.TotalCost > 100 && order.WeightInKG > 5)
            {
                return new DHL();
            }
            else 
            {
                return new RoyalMail();
            }
        }
    }
}
