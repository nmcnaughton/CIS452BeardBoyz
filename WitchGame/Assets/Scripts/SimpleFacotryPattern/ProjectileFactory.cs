using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFactory : MonoBehaviour
{

    
    protected float lifetime { get; set; }
    protected float moveSpeed { get; set; }
    public Rigidbody2D rb;

    public Transform player;
    public Vector2 moveDirection;


    void Start()
    {
        FindPlayer();


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Player hit by enemy");
           
            GameManager.Instance.currentHealth--; //taking away health 
            Invoke("Destroy", lifetime);
        }
    }


    public void FindPlayer()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        moveDirection = (player.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        //Invoke("Destroy", lifetime);
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }
}
