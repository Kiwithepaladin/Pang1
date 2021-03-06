using System.Collections;
using System.Collections.Generic;
using Pang.Weapons.Harpoon;
using UnityEngine;

namespace Pang.Weapons.Harpoon.Interfaces
{
    public interface IHasWeapon
    {
        IEnumerator ShootCoroutine();
    }
}