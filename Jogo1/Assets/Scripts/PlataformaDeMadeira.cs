using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaDeMadeira : MonoBehaviour
{
    public float plataformaTime;
    private BoxCollider2D boxColl;

    // Start is called before the first frame update
    void Start()
    {
        boxColl = GetComponent <BoxCollider2D> ();
    }

    void OnCollisionEnter2D (Collision2D collisor)
    {
        if (collisor.gameObject.layer == 8)
        {
            Invoke ("Plataforma", plataformaTime);
        }

    }

    void Plataforma () 
    {
        boxColl.isTrigger = true;
    }
}
