using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Services
{
    public abstract class Factory
    {
        public IProduct CreateProduct(int numberOfProduct)
        {
            return ConcreteFactory(numberOfProduct);
        }

        protected abstract IProduct ConcreteFactory(int numberOfProduct);
    }
}
