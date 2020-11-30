using Ragnarok.Models;
using Ragnarok.Services;
using Ragnarok.Services.Weapons;
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

            //CallEventBoss();

            WeaponDirector weaponDirector = new WeaponDirector();

            Console.WriteLine(JsonSerializer.Serialize(weaponDirector.CreateBasicWeapon(new SwordMaker())));
            Console.WriteLine(JsonSerializer.Serialize(weaponDirector.CreateFireWeapon(new SwordMaker())));

            Console.WriteLine("Bye bye!");
        }

        private static void CallEventBoss()
        {
            int damage = 10;

            Console.WriteLine(JsonSerializer.Serialize(Detardeurus.GetInstance(damage)));
            Console.WriteLine(JsonSerializer.Serialize(Detardeurus.GetInstance(damage)));
            Console.WriteLine(JsonSerializer.Serialize(Detardeurus.GetInstance(damage)));
            Console.WriteLine(JsonSerializer.Serialize(Detardeurus.GetInstance(damage)));
            Console.WriteLine(JsonSerializer.Serialize(Detardeurus.GetInstance(damage)));
            Console.WriteLine(JsonSerializer.Serialize(Detardeurus.GetInstance(damage)));

            var sig = Singleton.Instance;

            Console.WriteLine(JsonSerializer.Serialize(sig));
            Console.WriteLine(JsonSerializer.Serialize(Singleton.Instance));
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
