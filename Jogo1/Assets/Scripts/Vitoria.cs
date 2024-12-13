using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PainelVItoria : MonoBehaviour
{
    public GameObject gameOver;

   public void PainelVitoria (string lvlName)
    {
        SceneManager.LoadScene (lvlName);
    }
}
