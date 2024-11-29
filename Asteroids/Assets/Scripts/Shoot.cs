using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Vector3 velocity;
    public float speed;
    public static int damage = 20;
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
