using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private int _damage;
    private int _bullets;

    public void Fire(Player player)
    {
        player.TakeDamage(_damage);
        _bullets -= 1;
    }
}
