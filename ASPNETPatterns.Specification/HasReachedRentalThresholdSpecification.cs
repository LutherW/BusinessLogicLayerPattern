using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Specification
{
    public class HasReachedRentalThresholdSpecification : CompositeSpecification<CustomerAccount>
    {
        public override bool IsSatiesfiedBy(CustomerAccount candidate)
        {
            return candidate.NumberOfRentalThisMonth >= 5;
        }
    }
}
