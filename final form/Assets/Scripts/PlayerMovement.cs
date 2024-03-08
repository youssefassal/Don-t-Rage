using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private bool grounded;
    

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        gameObject.transform.localScale = new Vector3(0.25f,0.25f,0);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        gameObject.transform.localScale = new Vector3(-0.25f,0.25f,0);
        }
        if(Input.GetKey(KeyCode.W) && grounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        grounded = false;
        body.velocity = new Vector2(body.velocity.x, speed);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }

    
    }
}
