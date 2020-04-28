using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialObject : MonoBehaviour
{
    public GameObject featherObject;

    public GameObject Quest3;
    public GameObject Quest4;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Player picks up first feather");
            Quest3.SetActive(false); 
            Quest4.SetActive(true);
            Destroy(featherObject);

        }
    }
}
