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

            Slime mySlime = CreateNewSlime("Payon", "12:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = CreateNewSlime("Payon", "18:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = CreateNewSlime("Payon", "");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = CreateNewSlime("Desert", "12:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = CreateNewSlime("Desert", "19:00");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            mySlime = CreateNewSlime("Desert", "");
            Console.WriteLine(JsonSerializer.Serialize(mySlime));

            Console.WriteLine("Bye bye!");
        }

        private static Slime CreateNewSlime(string mapName, string currentTime)
        {
            if (mapName == "Payon")
            {
                if (currentTime == "12:00")
                {
                    return new Poring("Poison");
                }
                else if (currentTime == "18:00")
                {
                    return new Angeling();
                }
                else
                {
                    return new Poporing();
                }
            }
            else
            {
                if (currentTime == "12:00")
                {
                    return new Poring("Fire");
                }
                else if (currentTime == "19:00")
                {
                    return new Ghostring();
                }
                else
                {
                    return new Drops();
                }
            }
        }
    }
}
