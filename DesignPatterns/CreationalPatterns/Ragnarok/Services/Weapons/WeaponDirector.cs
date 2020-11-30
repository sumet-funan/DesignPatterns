using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services.Weapons
{
    public class WeaponDirector
    {
        public Weapon CreateBasicWeapon(IWeaponMaker maker)
        {
            return maker
                    .SetCreatorName("Saladpuk")
                    .GetWeapon();
        }

        public Weapon CreateFireWeapon(IWeaponMaker maker)
        {
            return maker
                    .SetElement("Fire")
                    .SetCreatorName("Saladpuk")
                    .GetWeapon();
        }
    }
}
