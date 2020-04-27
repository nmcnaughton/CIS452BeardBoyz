using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneTree : MonoBehaviour
{
    public GameObject QuestOne;
    public GameObject Questtwo;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Quest 1 Complete: Player touched tree");
            QuestOne.SetActive(false);
            Questtwo.SetActive(true);


        }
    }
}
