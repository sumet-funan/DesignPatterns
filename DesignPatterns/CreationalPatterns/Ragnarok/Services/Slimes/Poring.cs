using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class Poring : Slime
    {
        public Poring(string skill)
        {
            Name = "Poring";
            Skill = skill;
            IsBoss = false;
        }
    }
}
