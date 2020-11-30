using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class PecoPeco : GiantBird
    {
        public PecoPeco()
        {
            Name = nameof(PecoPeco);
            Skill = "Provocation";
            IsBoss = false;
        }
    }
}
