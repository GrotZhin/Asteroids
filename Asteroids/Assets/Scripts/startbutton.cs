using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_button : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("level");
        points.score = 0;
    }
      public void Menu()
    {
        SceneManager.LoadScene("start");
    }
}
    

