using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public interface IWeaponMaker
    {
        public SwordMaker SetName(string name);

        public SwordMaker SetElement(string element);

        public SwordMaker SetCreatorName(string name);

        public Weapon GetWeapon();
    }
}
