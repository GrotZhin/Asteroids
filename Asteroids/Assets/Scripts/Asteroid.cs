using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Vector3 rotate;
    public static Vector3 pos;
    Vector3 direction;
    Vector3 directionDefault;
    Vector3 direction2;
    Vector3 directionDebuff;
    Vector3 directionDebuff2;
    public GameObject boom;
    public GameObject rest;
 

    
    public int life = 100;
    public int value;

    void Start()
    {
        rotate = new Vector3(Random.Range(-80, 80), Random.Range(-80, 80), Random.Range(-80, 80));
        direction = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
        directionDefault = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
        direction2 = new Vector3(Random.Range(-7, 7), Random.Range(-7, 7), 0);
        directionDebuff = new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), 0);
        directionDebuff2 = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
        pos = transform.position;
    }

    void Update()
    {
        transform.Rotate(rotate.x * Time.deltaTime, rotate.y * Time.deltaTime, 0);
        transform.position += direction * Time.deltaTime;
        transform.position = Utility.Position(transform.position);
      
        if(points.score >= 60)
        {
            direction = direction2;
        }
        if (AsteroidSpeedDebuff.active == false && points.score < 60  )
        {
            direction = directionDefault;
        }
        else if (AsteroidSpeedDebuff.active == false && points.score >= 60  )
        {
            direction = direction2;
        }

        else if(AsteroidSpeedDebuff.active == true && points.score < 60)
        {
            direction = directionDebuff;
        }
        else if (AsteroidSpeedDebuff.active == true && points.score >= 60)
        {
            direction = directionDebuff2;
        }
    }
    public void TakeDamage(int damage)
    {
        life -= damage;

        if (life <= 0)
        {
            points.score += value;
            if (rest != null)
            {
                Instantiate(rest, transform.position, Quaternion.identity);
                Instantiate(rest, transform.position, Quaternion.identity);

            }
        

            Die();


        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("shoot"))
        {
            TakeDamage(Shoot.damage);
            Destroy(other.gameObject);


        }
    }
    public void Die()
    {
        Instantiate(boom, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

}
