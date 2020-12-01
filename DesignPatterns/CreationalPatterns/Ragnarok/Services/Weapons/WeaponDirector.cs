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
            var product = maker
                .SetCreatorName("Saladpuk")
                .GetWeapon();
            return product;
        }

        public Weapon CreateFireWeapon(IWeaponMaker maker)
            => createElementWeapon(maker, "Fire");

        public Weapon CreateWindWeapon(IWeaponMaker maker)
            => createElementWeapon(maker, "Wind");

        public Weapon CreateWaterWeapon(IWeaponMaker maker)
            => createElementWeapon(maker, "Water");

        public Weapon CreateEarthWeapon(IWeaponMaker maker)
            => createElementWeapon(maker, "Earth");

        private Weapon createElementWeapon(IWeaponMaker maker, string element)
        {
            var product = maker
                .SetElement(element)
                .SetCreatorName("Saladpuk")
                .GetWeapon();
            return product;
        }
    }
}
