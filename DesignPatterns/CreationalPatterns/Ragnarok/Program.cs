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

            PayonSlimeFactory payonSlimeFactory = new PayonSlimeFactory();

            Slime mySlime = payonSlimeFactory.CreateNewSlime("12:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = payonSlimeFactory.CreateNewSlime("18:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = payonSlimeFactory.CreateNewSlime("");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            DesertSlimeFactory desertSlimeFactory = new DesertSlimeFactory();

            mySlime = desertSlimeFactory.CreateNewSlime("12:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = desertSlimeFactory.CreateNewSlime("19:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = desertSlimeFactory.CreateNewSlime("");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            Console.WriteLine("Bye bye!");
        }
    }
}
