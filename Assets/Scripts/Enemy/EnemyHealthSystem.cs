using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth == 0){
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D other) 
    {
        
         if(other.gameObject.tag == "PlayerBullet")
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}