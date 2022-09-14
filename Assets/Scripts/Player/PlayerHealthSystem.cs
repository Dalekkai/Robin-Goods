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


    void Update()
    {
         if(currentHealth <= 0){
            LevelLoader.Respawn();
        }
    }

    // Checks how much dmg needs to be applyed
    private void OnTriggerEnter2D(Collider2D other) 
    {
       switch(other.gameObject.tag)
       {
           case "Bullet": // The dmg form shots 
           TakeDamage(1);
           break;
           case "MummyHit": // The dmg from mummy hits
           TakeDamage(2);
           break;
           case "FighterHit": // The dmg from fighter hits 
           TakeDamage(4);
           break;
           case "SmallBomb": // The dmg from fighter hits 
           TakeDamage(7);
           break;
           case "Death":
           LevelLoader.Respawn();
           break;
           default:
           break;
       }

    }

    //Applys the dmg
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);       
    }
}
