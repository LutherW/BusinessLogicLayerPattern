using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.DI
{
    public class ProductService
    {
        private IProductDiscountStrategy _discount;
        private IProductRepository _repository;

        public ProductService(IProductRepository productRepository) 
        {
            _discount = new ChristmasProductDiscount();
            _repository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts(IProductDiscountStrategy productDiscount) 
        {
            IEnumerable<Product> products = _repository.FindAll();
            foreach (Product p in products)
            {
                p.AdjustPriceWith(productDiscount);
            }

            return products;
        }
    }
}
