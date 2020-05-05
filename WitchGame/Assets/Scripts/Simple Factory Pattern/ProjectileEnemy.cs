using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : MonoBehaviour
{
    //public GameObject projectile;
    public float fireRate = 1f;
    float nextFire;
    ObjectPooler objectPooler;
    public string projectile;

    void Start()
    {
        objectPooler = ObjectPooler.instance;
        nextFire = Time.time;

    }
   


    void FixedUpdate()
    {
        CheckIfTimeToFire();
    }



    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            //Instantiate(projectile, transform.position, Quaternion.identity);
            objectPooler.SpawnFromPool(projectile, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;

        }
    }
}
