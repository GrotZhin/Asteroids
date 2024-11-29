using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClearStage : MonoBehaviour
{
    public static bool active;

    public GameObject model;

        

    void OnCollisionEnter(Collision other)
    {
        
        active = true;
        Destroy(gameObject);
    }
    
}
