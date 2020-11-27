using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Services
{
    public class LeoBeerFactory : Factory
    {
        protected override IProduct ConcreteFactory(int numberOfProduct)
        {
            return new LeoBeer(numberOfProduct);
        }
    }
}
