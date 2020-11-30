using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class GrandPeco : GiantBird
    {
        public GrandPeco()
        {
            Name = nameof(GrandPeco);
            Skill = "Fire";
            IsBoss = false;
        }
    }
}
