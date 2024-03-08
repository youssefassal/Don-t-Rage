using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity=-transform.right*Speed;
        //Destroy(gameObject,5);
    }
    
}
