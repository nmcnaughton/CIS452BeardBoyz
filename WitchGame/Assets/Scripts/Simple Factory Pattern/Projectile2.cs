using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : ProjectileFactory
{
    void Start()
    {

        this.moveSpeed = 7f;
        this.lifetime = 5f;
       
    }

    void Update()
    {
        FindPlayer();
    }
}
