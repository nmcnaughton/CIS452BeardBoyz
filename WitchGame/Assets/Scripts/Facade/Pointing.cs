using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointing : MonoBehaviour
{
    bool pointing = false;
    Vector2 pointDirection;
    Vector2 mousePos;
    GameObject character;
    GameObject umbrella;

    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player");
        umbrella = GameObject.FindGameObjectWithTag("Umbrella");
    }

    public void ToggleOn()
    {
        pointing = true;
        StartCoroutine(FollowMouse());
    }

    public void ToggleOff()
    {
        pointing = false;
        StopCoroutine(FollowMouse());
    }

    IEnumerator FollowMouse()
    {
        while(pointing)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (character == null || umbrella == null)
            {
                character = GameObject.FindGameObjectWithTag("Player");
                umbrella = GameObject.FindGameObjectWithTag("Umbrella");
            }
            pointDirection = (mousePos - new Vector2(character.transform.position.x, character.transform.position.y));
            pointDirection.Normalize();

            umbrella.transform.position = character.transform.position + new Vector3(pointDirection.x, pointDirection.y);
            yield return null;
        }
    }
}
