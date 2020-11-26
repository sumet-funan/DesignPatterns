using Ragnarok.Models;
using Ragnarok.Services;
using System;
using System.Text.Json;

namespace Ragnarok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ragnarok!");

            SimpleSlimeFactory simpleSlimeFactory = new SimpleSlimeFactory();

            Slime mySlime = simpleSlimeFactory.CreateNewSlime("Payon", "12:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = simpleSlimeFactory.CreateNewSlime("Payon", "18:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = simpleSlimeFactory.CreateNewSlime("Payon", "");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = simpleSlimeFactory.CreateNewSlime("Desert", "12:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = simpleSlimeFactory.CreateNewSlime("Desert", "19:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = simpleSlimeFactory.CreateNewSlime("Desert", "");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            Console.WriteLine("Bye bye!");
        }
    }
}
