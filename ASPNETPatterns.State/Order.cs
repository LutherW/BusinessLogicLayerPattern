using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.State
{
    public class Order
    {
        private IOrderState _orderState;

        public Order(IOrderState state) 
        {
            _orderState = state;
        }

        public int Id { get; set; }

        public string Customer { get; set; }

        public DateTime OrderedDate { get; set; }

        public OrderStatus Status()
        {
            return _orderState.Status;
        }

        public bool CanCancel() 
        {
            return _orderState.CanCancel(this);
        }

        public void Cancel() 
        {
            if (this.CanCancel())
            {
                _orderState.CanCancel(this);
            }
        }

        public bool CanShip() 
        {
            return _orderState.CanShip(this);
        }

        public void Ship() 
        {
            if (this.CanShip())
            {
                _orderState.Ship(this);
            }
        }

        internal void Change(IOrderState orderState) 
        {
            _orderState = orderState;
        }
    }
}
