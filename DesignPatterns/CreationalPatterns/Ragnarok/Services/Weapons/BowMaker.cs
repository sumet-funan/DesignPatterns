using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class BowMaker : IWeaponMaker
    {
        private int cardSlots = 2;
        private string elementType;
        private string creatorName;

        public IWeaponMaker SetElement(string element)
        {
            cardSlots = 0;
            elementType = element;
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
                Name = "Hunter",
                Element = elementType ?? "-",
                CreatorName = creatorName,
                PhysicalAttack = 10,
                MaximumSlots = cardSlots,
                MinimumAttackRange = 12,
                WeaponType = "bow"
            };
        }
    }
}
