using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : SingletonClass<GameManager>
{
    public int currentHealth = 10;
    public int maxHealth = 10;
    bool paused = false;
    public int currentScore = 0;
    GameObject winScreen;

    void Awake()
    {
        winScreen = GameObject.FindGameObjectWithTag("Win Screen");
        winScreen.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.GetComponent<Button>().onClick.AddListener(ResetGame);
        winScreen.transform.GetChild(0).gameObject.SetActive(false);
    }

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

        if (Input.GetKeyDown(KeyCode.Z))
        {
            WinGame();
        }

        if (currentScore >= 3)
        {
            WinGame();
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

    void WinGame()
    {
        Time.timeScale = 0.0f;
        if (winScreen == null)
        {
            winScreen = GameObject.FindGameObjectWithTag("Win Screen");
            winScreen.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.GetComponent<Button>().onClick.AddListener(ResetGame);
        }
        winScreen.transform.GetChild(0).gameObject.SetActive(true);

    }

    public void ResetGame()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1.0f;
        currentHealth = 10;
        currentScore = 0;
    }
}

