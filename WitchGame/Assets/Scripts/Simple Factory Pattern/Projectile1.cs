using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : ProjectileFactory
{
   
    void Start()
    {
        
        this.moveSpeed = 10f;
        this.lifetime = 2.0f;
        FindPlayer();
    }
    
   
}
