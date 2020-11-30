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

            //CallSlimes();

            //CallMosters();

            Console.WriteLine("Bye bye!");
        }

        private static void CallMosters()
        {
            IMonsterFactory monsterFactory = new PayonMonsterFactory();
            Console.WriteLine(JsonSerializer.Serialize(monsterFactory.CreateASlime()));
            Console.WriteLine(JsonSerializer.Serialize(monsterFactory.CreateAWolf()));
            Console.WriteLine(JsonSerializer.Serialize(monsterFactory.CreateAGiantBird()));

            monsterFactory = new DesertMonsterFactory();
            Console.WriteLine(JsonSerializer.Serialize(monsterFactory.CreateASlime()));
            Console.WriteLine(JsonSerializer.Serialize(monsterFactory.CreateAWolf()));
            Console.WriteLine(JsonSerializer.Serialize(monsterFactory.CreateAGiantBird()));
        }

        private static void CallSlimes()
        {
            SlimeFactory slimeFactory = new PayonSlimeFactory();

            Slime mySlime = slimeFactory.CreateNewSlime("12:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = slimeFactory.CreateNewSlime("18:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = slimeFactory.CreateNewSlime("");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            slimeFactory = new DesertSlimeFactory();

            mySlime = slimeFactory.CreateNewSlime("12:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = slimeFactory.CreateNewSlime("19:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = slimeFactory.CreateNewSlime("");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));
        }
    }
}
