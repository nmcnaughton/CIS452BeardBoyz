using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerUI : Subject
{
    //Manages the UI of the player

    Observer healthBar;

    Observer scoreText;

    GameManager manager;

    public UnityEvent scoreEvent;

    void Start()
    {
        manager = GameManager.Instance;
        healthBar = new HealthBar();
        scoreText = new Score();

        AddObserver(healthBar);
        AddObserver(scoreText);

        scoreEvent = new UnityEvent();
        scoreEvent.AddListener(Notify);
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
