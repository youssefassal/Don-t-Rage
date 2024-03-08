using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D boxCollider;
    public float distanse;
    bool isFalling =false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        if (isFalling == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position,Vector2.down, distanse);
            Debug.DrawRay(transform.position, Vector2.down*distanse,Color.black);
            if(hit.transform != null )
            {
                if(hit.transform.tag == "Player")
                {
                    rb.gravityScale = 10;
                    isFalling = true;
                }
            }
        }
    }
}
