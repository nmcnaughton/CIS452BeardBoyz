using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawnEnemyTrigger : MonoBehaviour
{
    public GameObject Enemy;
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Spawn Enemy1");
            Enemy.SetActive(false);

        }
    }
}
