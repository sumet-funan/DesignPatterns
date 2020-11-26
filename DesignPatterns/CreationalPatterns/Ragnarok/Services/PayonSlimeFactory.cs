using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class PayonSlimeFactory : SlimeFactory
    {
        protected override Slime BuildASlime(string currentTime)
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
    }
}
