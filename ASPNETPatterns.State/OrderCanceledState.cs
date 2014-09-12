using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.State
{
    public class OrderCanceledState : IOrderState
    {
        public OrderStatus Status
        {
            get
            {
                return OrderStatus.Canceled;
            }
        }

        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("您不能发货一个已取消的订单");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("这个订单已经取消了，不能重复取消");
        }
    }
}
