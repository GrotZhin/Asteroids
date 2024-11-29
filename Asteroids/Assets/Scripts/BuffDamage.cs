using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuffDamage : MonoBehaviour
{
    bool active;
    float time;
    public GameObject model;
    public new SphereCollider collider;
        

    void OnCollisionEnter(Collision other)
    {
        Shoot.damage = 40;
        active = true;
        collider.enabled = false;
        Destroy(model);
    }
    void Update()
    {
        if(active == true)
        {
            time += Time.deltaTime;
            if (time >= 10)
            {
                Shoot.damage = 20;
                active = false;
                time = 0;
                Destroy(gameObject);
            }
        }

    }
}
