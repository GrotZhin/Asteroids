using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
      public TextMeshProUGUI textpoint; 
      public static int score;
      
      
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         textpoint.text= "" + score;
    }
}
