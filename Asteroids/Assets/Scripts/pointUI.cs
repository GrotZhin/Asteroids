using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
      public TextMeshProUGUI textpoint; 

     public TextMeshProUGUI texthpoint;

     public TextMeshProUGUI textfinalpoint;  

     public static int score;

    


     
      
      
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
         
         textpoint.text= "" + score.ToString();
    }
    public void Awake(){
      DontDestroyOnLoad(this.gameObject);
    }

     public void Highscore()
     {

          if (PlayerPrefs.HasKey("savedHighscore"))
          {
               if (score > PlayerPrefs.GetInt("savedHighscore"))
               {
                    PlayerPrefs.SetInt("savedHighscore",score);
               }

          }
          else
          {
                PlayerPrefs.SetInt("savedHighscore",score);
          }

          textfinalpoint.text = ("" + score).ToString();
          texthpoint.text =  PlayerPrefs.GetInt("savedHighscore").ToString();
          

     }

 
    }

