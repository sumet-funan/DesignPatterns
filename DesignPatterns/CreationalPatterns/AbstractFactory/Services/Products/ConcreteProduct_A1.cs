using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services.Products
{
    public class ConcreteProduct_A1 : ProductA
    {
        public ConcreteProduct_A1()
        {
            Name = nameof(ConcreteProduct_A1);
            Price = 29.9M;
        }
    }
}
