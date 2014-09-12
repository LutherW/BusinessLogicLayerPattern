using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatiesfiedBy(T candidate);

        ISpecification<T> And(ISpecification<T> other);
        ISpecification<T> Not();
        ISpecification<T> Or(ISpecification<T> other);
    }
}
