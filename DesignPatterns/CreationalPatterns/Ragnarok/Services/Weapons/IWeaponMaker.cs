using Ragnarok.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public interface IWeaponMaker
    {
        IWeaponMaker SetElement(string elementType);
        IWeaponMaker SetCreatorName(string name);
        Weapon GetWeapon();
    }
}
