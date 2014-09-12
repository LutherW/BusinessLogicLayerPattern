using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Specification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatiesfiedBy(T candidate);

        public ISpecification<T> And(ISpecification<T> other) 
        {
            return new AndSpecification<T>(this, other);
        }

        public ISpecification<T> Not() 
        {
            return new NotSpecification<T>(this);
        }

        public ISpecification<T> Or(ISpecification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }
    }
}
