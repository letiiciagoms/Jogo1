using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    Pato Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject.GetComponent <Pato> ();
    }

    void OnCollisionEnter2D (Collision2D collisor)
    {
        if (collisor.gameObject.layer == 8)
        {
            Player.isJumping = false;
        }



    }

    void OnCollisionExit2D (Collision2D collisor)
    {
        if (collisor.gameObject.layer == 8)
        {
            Player.isJumping = true;
        }

       
    }

}

