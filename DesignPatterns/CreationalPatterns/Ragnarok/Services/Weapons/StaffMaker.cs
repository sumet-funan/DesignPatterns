using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class StaffMaker : IWeaponMaker
    {
        private string creatorName;

        public IWeaponMaker SetElement(string element)
        {
            return this;
        }

        public IWeaponMaker SetCreatorName(string name)
        {
            creatorName = name;
            return this;
        }

        public Weapon GetWeapon()
        {
            return new Weapon
            {
                Name = "Soul",
                Element = "-",
                CreatorName = creatorName,
                MagicalAttack = 10,
                MaximumSlots = 2,
                MinimumAttackRange = 5,
                WeaponType = "staff"
            };
        }
    }
}
