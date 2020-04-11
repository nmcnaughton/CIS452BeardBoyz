using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : Observer
{
    public GameObject healthBar;
    public override void OnNotify()
    {
        if (healthBar == null)
        {
            FindHealthBar();
        }
        healthBar.transform.GetChild(0).GetComponent<Image>().fillAmount = (float) GameManager.Instance.currentHealth / GameManager.Instance.maxHealth;
    }

    // Start is called before the first frame update
    void Start()
    {
        FindHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FindHealthBar()
    {
        healthBar = GameObject.FindGameObjectWithTag("Health Bar");
    }
}
