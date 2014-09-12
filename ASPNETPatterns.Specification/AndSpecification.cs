using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Specification
{
    public class AndSpecification<T>: CompositeSpecification<T>
    {
        private ISpecification<T> _leftSpecification;
        private ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification) 
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override bool IsSatiesfiedBy(T candidate)
        {
            return _leftSpecification.IsSatiesfiedBy(candidate) 
                && _rightSpecification.IsSatiesfiedBy(candidate);
        }
    }
}
