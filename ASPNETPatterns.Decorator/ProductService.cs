using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Decorator
{
    public class ProductService
    {
        private IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProducts() 
        {
            IEnumerable<Product> products = _repository.FindAll();
            products.ApplyCurrencyMultiplier();
            products.ApplyTradeDiscount();

            return products;
        }
    }
}
