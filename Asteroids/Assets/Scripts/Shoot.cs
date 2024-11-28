using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Vector3 velocity;
    public float speed;
    void Start()
    {
        Destroy(this.gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity  * speed * Time.deltaTime;
    }
}
