using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Services
{
    public class CannedFish : IProduct
    {
        private readonly int _numberOfProduct;

        public CannedFish(int numberOfProduct)
        {
            _numberOfProduct = numberOfProduct;
        }
        public IEnumerable<Product> BuildProduct()
        {
            for (int i = 0; i < _numberOfProduct; i++)
            {
                yield return new Product
                {
                    Name = "3Chef",
                    Price = 15,
                    ExpirationDate = DateTime.UtcNow.AddDays(720)
                };
            }
        }
    }
}
