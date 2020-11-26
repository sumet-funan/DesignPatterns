using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class SimpleSlimeFactory
    {
        public Slime CreateNewSlime(string mapName, string currentTime)
        {
            if (mapName == "Payon")
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
            else
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
}
