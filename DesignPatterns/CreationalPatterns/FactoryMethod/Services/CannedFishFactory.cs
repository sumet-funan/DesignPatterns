using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Services
{
    public class CannedFishFactory : Factory
    {
        protected override IProduct ConcreteFactory(int numberOfProduct)
        {
            return new CannedFish(numberOfProduct);
        }
    }
}
