using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.DI
{
    public class LinqProductRepository : IProductRepository
    {
        public IEnumerable<Product> FindAll() 
        {
            return new List<Product>();
        }
    }
}
