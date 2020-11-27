using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public interface IMonsterFactory
    {
        public Slime CreateASlime();
        public Wolf CreateAWolf();
        public GiantBird CreateAGiantBird();
    }
}
