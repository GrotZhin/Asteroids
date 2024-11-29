using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int life = 100;
    
    public int damage = 20;
    public TextMeshProUGUI textLife;
    void Start()
    {
        
    }


    void Update()
    {
        this.textLife.text = life.ToString();
    }
    public void TakeDamage(int damage)
    {
        life -= damage;

        if (life <= 0)
        {
            Die();
             SceneManager.LoadScene("lose");

        }

    }
    void OnCollisionEnter(Collision other)
    {
        Asteroid asteroid = other.collider.GetComponent<Asteroid>();
        if (asteroid != null)
        {
            asteroid.Die();
            TakeDamage(damage);
        }
    }
    public void Die()
    {
        Destroy(this.gameObject);

    }
}
