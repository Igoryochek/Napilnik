using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; private set; }

    public void TakeDamage(int damage)
    {
        int currentDamage = Health - damage;
        if (currentDamage <= 0)
            throw new InvalidOperationException();
        else
            Health = currentDamage;
    }
}
