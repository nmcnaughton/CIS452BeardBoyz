using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : Subject
{
    //Manages the UI of the player

    Observer healthBar;

    void Start()
    {
        healthBar = new HealthBar();

        AddObserver(healthBar);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            GameManager.Instance.currentHealth--;
            Notify();
        }
    }
}
