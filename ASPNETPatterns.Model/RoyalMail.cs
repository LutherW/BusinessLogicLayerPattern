using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Model
{
    public class RoyalMail : IShippingCourier
    {
        public string GenerateConsignmentLableFor(Address address)
        {
            return "RM-" + Guid.NewGuid().ToString();
        }
    }
}
