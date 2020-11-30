using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services.Products
{
    public class ConcreteProduct_A2 : ProductA
    {
        public ConcreteProduct_A2()
        {
            Name = nameof(ConcreteProduct_A2);
            Price = 25.9M;
        }
    }
}
