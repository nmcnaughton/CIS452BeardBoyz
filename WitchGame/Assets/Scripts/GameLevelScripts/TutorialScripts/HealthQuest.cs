using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthQuest : MonoBehaviour
{
    public GameObject Quest5;
    public GameObject HealthbarQuest;
    public bool HealthquestComplete;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && !HealthquestComplete)
        {
            Debug.Log("Quest 2 Complete: Player jumped to the platform");
            Quest5.SetActive(false);
            HealthbarQuest.SetActive(true);
            HealthquestComplete = true;


        }
    }

}
