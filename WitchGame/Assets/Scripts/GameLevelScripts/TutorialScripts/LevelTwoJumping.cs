using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwoJumping : MonoBehaviour
{
    public GameObject QuestTwo;
    public GameObject QuestThree;
    public bool Quest2Completed;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && !Quest2Completed)
        {
            Debug.Log("Quest 2 Complete: Player jumped to the platform");
            QuestTwo.SetActive(false);
            QuestThree.SetActive(true);
            Quest2Completed = true;


        }
    }
}

