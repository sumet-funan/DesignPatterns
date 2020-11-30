using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services.Products
{
    public class ConcreteProduct_B1 : ProductB
    {
        public ConcreteProduct_B1()
        {
            Name = nameof(ConcreteProduct_B1);
            Price = 10;
            Expire = DateTime.UtcNow.AddDays(365);
        }
    }
}
