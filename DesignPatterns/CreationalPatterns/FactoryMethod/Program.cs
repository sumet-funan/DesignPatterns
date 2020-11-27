using FactoryMethod.Services;
using System;
using System.Text.Json;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Factory factory = new CannedFishFactory();
            Console.WriteLine(JsonSerializer.Serialize(factory.CreateProduct(1).BuildProduct()));

            factory = new LeoBeerFactory();
            Console.WriteLine(JsonSerializer.Serialize(factory.CreateProduct(10).BuildProduct()));
        }
    }
}
