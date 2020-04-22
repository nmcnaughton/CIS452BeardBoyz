using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : ProjectileFactory
{
    void Start()
    {

        this.moveSpeed = 5f;
        this.deathspeed = .2f;
        FindPlayer();
    }
}
