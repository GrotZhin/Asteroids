using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 directionVelocity;
    [SerializeField] float speed;
    public GameObject shoot;
    public Transform firePoint;
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
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }
        void Shoot()
        {
         GameObject obj = Instantiate(shoot, transform.position, firePoint.transform.rotation);
         obj.GetComponent<Shoot>().velocity = firePoint.transform.up;
        }

    }
}
