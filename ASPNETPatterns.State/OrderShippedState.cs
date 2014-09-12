using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.State
{
    public class OrderShippedState : IOrderState
    {
        public OrderStatus Status
        {
            get { return OrderStatus.Shipped; }
        }

        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("已经发货");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("已经发货的的订单不能取消");
        }
    }
}
