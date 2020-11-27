using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Services
{
    public class LeoBeer : IProduct
    {
        private readonly int _numberOfProduct;

        public LeoBeer(int numberOfProduct)
        {
            _numberOfProduct = numberOfProduct;
        }

        public IEnumerable<Product> BuildProduct()
        {
            for (int i = 0; i < _numberOfProduct; i++)
            {
                yield return new Product
                {
                    Name = "Leo",
                    Price = 40,
                    ExpirationDate = DateTime.UtcNow.AddDays(365)
                };
            }
        }
    }
}
