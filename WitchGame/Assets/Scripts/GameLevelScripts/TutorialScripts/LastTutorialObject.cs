using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastTutorialObject : MonoBehaviour
{
    public GameObject lastfeatherObject;

    public GameObject LastTutorialQuest;
    public GameObject Quest5;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Player picks up first feather");
            LastTutorialQuest.SetActive(false);
            Quest5.SetActive(true);
            
            Destroy(lastfeatherObject);

        }
    }
}
