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

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0){
            Destroy(gameObject);
            isDead = true;
        }
    }


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

            default: 
            break;

        }
        
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(healthBar != null )
        {
            healthBar.SetHealth(currentHealth);
        }
    }

}