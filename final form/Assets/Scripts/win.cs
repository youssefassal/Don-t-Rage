using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "win")
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    
}