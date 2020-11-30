using AbstractFactory.Services;
using System;
using System.Text.Json;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("ConcreteFactory_1");
            IAbstractFactory abstractFactory = new ConcreteFactory_1();
            Console.WriteLine(JsonSerializer.Serialize(abstractFactory.CreateProductA()));
            Console.WriteLine(JsonSerializer.Serialize(abstractFactory.CreateProductB()));

            Console.WriteLine("ConcreteFactory_2");
            abstractFactory = new ConcreteFactory_2();
            Console.WriteLine(JsonSerializer.Serialize(abstractFactory.CreateProductA()));
            Console.WriteLine(JsonSerializer.Serialize(abstractFactory.CreateProductB()));

            Console.WriteLine("Bye bye");
        }
    }
}
