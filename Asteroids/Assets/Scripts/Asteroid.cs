using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Vector3 rotate;
    Vector3 direction;
    void Start()
    {
        rotate = new Vector3(Random.Range(-80, 80),Random.Range(-80, 80),Random.Range(-80, 80));
        direction = new Vector3(Random.Range(-10,10), Random.Range(-10,10), 0);
    }

    void Update()
    {
         transform.Rotate(rotate.x * Time.deltaTime, rotate.y * Time.deltaTime, 0);
         transform.position += direction * Time.deltaTime;
         transform.position = Utility.Position(transform.position);
    }
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("shoot"));
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
