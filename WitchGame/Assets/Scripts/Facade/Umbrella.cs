using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umbrella : MonoBehaviour
{
    bool open = false;
    GameObject umbrella;

    void Start()
    {
        umbrella = GameObject.FindGameObjectWithTag("Umbrella");
        umbrella.SetActive(false);
    }

    public void ToggleOn()
    {
        open = true;
        
        if (umbrella == null)
        {
            umbrella = GameObject.FindGameObjectWithTag("Umbrella");
        }

        umbrella.SetActive(open);
        
    }

    public void ToggleOff()
    {
        open = false;

        if (umbrella == null)
        {
            umbrella = GameObject.FindGameObjectWithTag("Umbrella");
        }

        umbrella.SetActive(open);
    }
}
