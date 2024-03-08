using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpForce ;
    bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            jump();
        }
        if(isGrounded)
        {
            JumpForce = 5;
        }

    }
    void jump()
    {
        rb.velocity = Vector2.up * JumpForce;
        isGrounded = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = true;
        }
        if(collision.collider.tag == "Tramp" &&  !isGrounded)
        {
            JumpForce += 5;
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);

        }
    }
}
