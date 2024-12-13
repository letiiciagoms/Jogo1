using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public string lvlName;
 void OnCollisionEnter2D (Collision2D collisor)
    {
        if (collisor.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(lvlName);
        }
    }
}
