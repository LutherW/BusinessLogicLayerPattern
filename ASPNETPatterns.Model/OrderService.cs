using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Model
{
    public class OrderService
    {
        public void Dispatch(Order order) 
        {
            IShippingCourier shippingCourier = ShippingCourierFactory.CreateShippingCourier(order);

            order.CourierTrackingId = shippingCourier.GenerateConsignmentLableFor(order.DispathAddress);
        }
    }
}
