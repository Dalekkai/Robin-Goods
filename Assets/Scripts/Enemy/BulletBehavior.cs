using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
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
            case "Enemy":
            break;

            case "Player":
            Destroy(gameObject, 0.1f); 
            break;

            default:
            Destroy(gameObject); 
            break;            
        }        
    }
}
