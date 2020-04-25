using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : SingletonClass<Facade>
{
    bool toggled = false;

    void Start()
    {

        gameObject.AddComponent<Umbrella>();
        gameObject.AddComponent<Pointing>();
        gameObject.AddComponent<Dash>();
        
    }

    public void OpenUmbrella()
    {
        GetComponent<Umbrella>().ToggleOn();
        GetComponent<Pointing>().ToggleOn();
        toggled = true;
    }

    public void CloseUmbrella()
    {
        GetComponent<Umbrella>().ToggleOff();
        GetComponent<Pointing>().ToggleOff();
        GetComponent<Dash>().PerformDash();
        toggled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && !toggled)
        {
            OpenUmbrella();
            toggled = true;
        }

        else if (Input.GetKeyDown(KeyCode.Mouse1) && toggled)
        {
            CloseUmbrella();
            toggled = false;
        }
    }
}
