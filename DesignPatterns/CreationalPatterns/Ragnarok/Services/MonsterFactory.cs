using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class MonsterFactory
    {
        public Slime CreateASlime(string mapName)
        {
            if (mapName == "payon")
            {
                return new Poporing();
            }
            else
            {
                return new Drops();
            }
        }

        public Wolf CreateAWolf(string mapName)
        {
            if (mapName == "payon")
            {
                return new WildWolf();
            }
            else
            {
                return new DesertWolf();
            }
        }

        public GiantBird CreateAGiantBird(string mapName)
        {
            if (mapName == "payon")
            {
                return new PecoPeco();
            }
            else
            {
                return new GrandPeco();
            }
        }
    }
}
