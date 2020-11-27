using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class DesertMonsterFactory : IMonsterFactory
    {
        public Slime CreateASlime()
        {
            return new Drops();
        }

        public Wolf CreateAWolf()
        {
            return new DesertWolf();
        }

        public GiantBird CreateAGiantBird()
        {
            return new GrandPeco();
        }
    }
}
