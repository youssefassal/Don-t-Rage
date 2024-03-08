using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomenu : MonoBehaviour
{
    [SerializeField] AudioSource musicsource;
    public AudioClip background;
    public static Audiomanager instance;

    void Start()
    {
        musicsource.clip = background;
        musicsource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
