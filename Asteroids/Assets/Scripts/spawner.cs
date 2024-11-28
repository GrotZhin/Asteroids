using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject obj;
    float counter;
     public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter +=Time.deltaTime;

        if (counter >= timer)
        {
            Vector3 randomspawn = new Vector3(Random.Range(-11,9),5,0);
            Instantiate(obj,randomspawn,Quaternion.identity);
            counter =0;
        }

        
    }
}
