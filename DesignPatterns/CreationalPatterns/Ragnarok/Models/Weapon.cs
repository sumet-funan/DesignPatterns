using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Models
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public string CreatorName { get; set; }
        public int MaximumSlots { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicalAttack { get; set; }
        public string WeaponType { get; set; }
        public int MinimumAttackRange { get; set; }
    }
}
