using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBlade : MonoBehaviour
{
    public float rotationSpeed;
    public Transform pos1;
    public Transform pos2;
    bool turnBack;
    public float movementspeed;
    void Update()
    {
        transform.Rotate(0,0,rotationSpeed*Time.deltaTime);
        if (transform.position.x <= pos1.position.x)
        {
            turnBack = true;
        }
        else if(transform.position.x >= pos2.position.x)
        {
            turnBack= false;
        }

        if(turnBack )
        {
            transform.position = Vector2.MoveTowards(transform.position, pos2.position, movementspeed * Time.deltaTime);
        }
        else 
        {
            transform.position = Vector2.MoveTowards(transform.position, pos1.position, movementspeed * Time.deltaTime);

        }
    }

}
