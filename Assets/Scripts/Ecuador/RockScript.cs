using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{

    public GameObject explosion;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Death"){Destroy(gameObject);} 
        else 
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
        
    }

}
