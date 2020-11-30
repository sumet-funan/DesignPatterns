using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services
{
    public interface IAbstractFactory
    {
        public ProductA CreateProductA();
        public ProductB CreateProductB();
    }
}
