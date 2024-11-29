using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 directionVelocity;
    [SerializeField] float speed;
    public GameObject shoot;
    public Transform[] firePoints;
     public Transform firePoint;
    public float fireTimer;
    public static float fireRate = 0.15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Input.mousePosition;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(position);
        Vector3 direction = mousePos - transform.position;
        Vector3 pos = transform.position;
        direction = direction.normalized;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);



        if (Input.GetMouseButtonDown(0))
        {
            directionVelocity += new Vector3(direction.x, direction.y, 0);
        }

        transform.position += directionVelocity * speed * Time.deltaTime;
        transform.position = Utility.Position(transform.position);

        fireTimer += Time.deltaTime;

        if (fireTimer >= fireRate && Input.GetMouseButtonDown(1))
        {

            Shoot();
            fireTimer = 0f;

        }
      


    }
    void Shoot()
    {
          if (DoubleShoot.active == false)
            {
                GameObject obj = Instantiate(shoot, firePoints[0].position, firePoints[0].transform.rotation);
                firePoint = firePoints[0];
                obj.GetComponent<Shoot>().velocity = firePoint.transform.up;
                
            }
            else if(DoubleShoot.active == true)
            {
              GameObject obj = Instantiate(shoot, firePoints[1].position, firePoints[1].transform.rotation);
                firePoint = firePoints[1];
                obj.GetComponent<Shoot>().velocity = firePoint.transform.up;
                GameObject obj1 = Instantiate(shoot, firePoints[2].position, firePoints[2].transform.rotation);
                firePoint = firePoints[2];
                obj1.GetComponent<Shoot>().velocity = firePoint.transform.up;
            }
          
      
    }
}
