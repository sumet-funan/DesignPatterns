using AbstractFactory.Models;
using AbstractFactory.Services.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services
{
    public class ConcreteFactory_1 : IAbstractFactory
    {
        public ProductA CreateProductA()
        {
            return new ConcreteProduct_A1();
        }

        public ProductB CreateProductB()
        {
            return new ConcreteProduct_B1();
        }
    }
}
