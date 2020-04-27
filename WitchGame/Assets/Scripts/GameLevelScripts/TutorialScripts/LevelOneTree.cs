using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneTree : MonoBehaviour
{
    public GameObject QuestOne;
    public GameObject Questtwo;
    public bool Quest1Completed;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && !Quest1Completed)
        {
            Debug.Log("Quest 1 Complete: Player touched tree");
            QuestOne.SetActive(false);
            Questtwo.SetActive(true);
            Quest1Completed = true;


        }
    }
}
