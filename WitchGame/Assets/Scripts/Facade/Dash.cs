using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    Vector2 mousePos = new Vector2();
    Vector2 dashDirection = new Vector2();
    GameObject character;

    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player");
    }

    public void PerformDash()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (character == null)
        {
            character = GameObject.FindGameObjectWithTag("Player");
        }

        dashDirection = (mousePos - new Vector2(character.transform.position.x, character.transform.position.y));
        dashDirection.Normalize();
        character.GetComponent<Rigidbody2D>().AddForce(20f * dashDirection, ForceMode2D.Impulse);
    }
    
}
