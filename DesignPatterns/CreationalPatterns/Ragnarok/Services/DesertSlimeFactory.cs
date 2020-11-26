using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class DesertSlimeFactory
    {
        public Slime CreateNewSlime(string currentTime)
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
