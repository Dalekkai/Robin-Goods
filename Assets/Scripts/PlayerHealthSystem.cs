using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour 
{
    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthBar; //Fehler keine Auswirkungen?
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) 
    {
    }
    private void OnCollisionEnter(Collision other) {
        
          //if(other.gameObject.tag == "Bullet") Zwei Collider? Isabel fragen
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
