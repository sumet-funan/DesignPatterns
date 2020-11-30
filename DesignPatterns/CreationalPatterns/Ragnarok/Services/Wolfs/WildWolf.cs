using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class WildWolf : Wolf
    {
        public WildWolf()
        {
            Name = nameof(WildWolf);
            Skill = "Earth";
            IsBoss = false;
        }
    }
}
