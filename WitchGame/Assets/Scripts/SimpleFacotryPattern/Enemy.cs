using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject bullet;
    public float fireRate =1f;
     float  nextFire;
    

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
        if(Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;

        }
    }
}
