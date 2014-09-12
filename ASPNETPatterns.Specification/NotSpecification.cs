using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Specification
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> _innerSpecification;

        public NotSpecification(ISpecification<T> innerSpecification) 
        {
            _innerSpecification = innerSpecification;
        }

        public override bool IsSatiesfiedBy(T candidate)
        {
            return !_innerSpecification.IsSatiesfiedBy(candidate);
        }
    }
}
