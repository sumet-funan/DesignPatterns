using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public abstract class SlimeFactory
    {
        public Slime CreateNewSlime(string currentTime)
        {
            return BuildASlime(currentTime);
        }

        protected abstract Slime BuildASlime(string currentTime);
    }
}
