using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float time;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D coll) 
    {
        if(coll.gameObject.tag == "Player")
        {
            Destroy(gameObject, time);
        }
    }
}
