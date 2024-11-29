using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform pato;

    private void FixedUpdate ()
    {
	    transform.position = Vector2.Lerp (transform.position, pato.position, 0.1f);
    }
}



