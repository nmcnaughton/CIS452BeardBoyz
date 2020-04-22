using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : MonoBehaviour
{
    public GameObject projectile;
    public float fireRate = 1f;
    float nextFire;


    void Start()
    {
        nextFire = Time.time;


    }


    void Update()
    {
        CheckIfTimeToFire();
    }



    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;

        }
    }
}
