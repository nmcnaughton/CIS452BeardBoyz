using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbrellaQuest : MonoBehaviour
{
    public GameObject LastQuest;
    public GameObject TutorialUmbrellaQuest;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Tell Player about Umbrella");
            LastQuest.SetActive(false);
            TutorialUmbrellaQuest.SetActive(true);


        }
    }
}
