using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    float TimeBetween;
    public float StartTimeBetween;
    void Start()
    {
        TimeBetween = StartTimeBetween;
    }

  
    void Update()
    {
        if(TimeBetween <= 0)
        {
            Instantiate(bullet,firePoint.position,firePoint.rotation);
            TimeBetween = StartTimeBetween;
        }
        else
        {
            TimeBetween -= Time.deltaTime;
        }
    }
}
