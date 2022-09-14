using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletBehaviour : MonoBehaviour
{
    private void Start() 
    {
        Destroy(gameObject, 20); 

    }

     //Lets the bullet fly through enemys. Otherways gets destroyed
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch(other.gameObject.tag)
        {
            case "Player":
            break;

            case "Enemy":
            Destroy(gameObject, 0.1f); 
            break;

            case "FighterHit":
            Destroy(gameObject, 0.2f); 
            break;

            case "MummyHit":
            Destroy(gameObject, 0.2f); 
            break;

            default:
            Destroy(gameObject); 
            break;            
        }        
    }
}
