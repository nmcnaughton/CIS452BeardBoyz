using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : Observer
{
    public GameObject score;
    public override void OnNotify()
    {
        if (score == null)
        {
            FindScore();
        }
        score.transform.GetChild(0).GetComponent<Text>().text = GameManager.Instance.currentScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        FindScore();
        score.transform.GetChild(0).GetComponent<Text>().text = GameManager.Instance.currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FindScore()
    {
        score = GameObject.FindGameObjectWithTag("Score");
    }
}
