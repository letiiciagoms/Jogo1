using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
   public GameObject gameOver;
   public GameObject Vitoria;
   public static GameController instance;


   void Start()
   {
     instance = this;
   }

   public void ShowGameOver()
   {
       gameOver.SetActive(true);
   }

   public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void ShowVitoria ()
    {
        Vitoria.SetActive (true);
    }

    public void PainelVitoria (string lvlName)
    {
        SceneManager.LoadScene (lvlName);
    }

    

}
