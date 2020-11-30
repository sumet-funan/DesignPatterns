using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services.Products
{
    public class ConcreteProduct_B2 : ProductB
    {
        public ConcreteProduct_B2()
        {
            Name = nameof(ConcreteProduct_B2);
            Price = 9;
            Expire = DateTime.UtcNow.AddDays(30);
        }
    }
}
