using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydie : MonoBehaviour
{
    public GameObject enemy;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Player destroys enemy");

            Destroy(enemy);


        }
    }
}
