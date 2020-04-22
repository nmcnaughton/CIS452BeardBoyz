using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonClass<GameManager>
{
    public int currentHealth = 10;
    public int maxHealth = 10;
    bool paused = false;
    public int currentScore = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                UnPause();
            }
            
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        paused = true;
    }

    void UnPause()
    {
        Time.timeScale = 1.0f;
        paused = false;
    }
}

