using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthBar;
    public bool isDead = false;

    
    void Start()
    {
        currentHealth = maxHealth;
    }

    //Checks if enemy is still alive
    void Update()
    {
        if(currentHealth <= 0){
            Destroy(gameObject);
            isDead = true;
        }
    }


    //Lets the enemy take damage from different weapons
    private void OnTriggerEnter2D(Collider2D other) 
    {
        
         if(other.gameObject.tag == "PlayerBullet")
        {
            TakeDamage(1);
        }
        switch(other.gameObject.tag)
        {
            case "PlayerBullet":
            TakeDamage(1);
            break;

            case "Sword":
            TakeDamage(3);
            break;

            case "Speer":
            TakeDamage(4);
            break;

            case "ThrownSpeer":
            TakeDamage(10);
            break;

            default: 
            break;

        }
        
        
    }

        private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Sword")
        {
            TakeDamage(3);
        }
    }



    //Applys the damage
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(healthBar != null )
        {
            healthBar.SetHealth(currentHealth);
        }
    }

}