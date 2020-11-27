using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Services
{
    public interface IProduct
    {
        public IEnumerable<Product> BuildProduct();
    }
}
