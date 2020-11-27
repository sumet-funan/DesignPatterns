using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class PayonMonsterFactory : IMonsterFactory
    {
        public Slime CreateASlime()
        {
            return new Poporing();
        }

        public Wolf CreateAWolf()
        {
            return new WildWolf();
        }

        public GiantBird CreateAGiantBird()
        {
            return new PecoPeco();
        }
    }
}
