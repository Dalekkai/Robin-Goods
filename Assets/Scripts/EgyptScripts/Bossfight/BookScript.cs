using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour
{

    void Start()
    {
        //Destroys the object after 10 secs to save memory and performance
        Destroy(gameObject, 10f);
    }

    //Destroys the book after impact
        private void OnTriggerEnter2D(Collider2D other) 
    {
        switch(other.gameObject.tag)
        {
            case "Player":
            Destroy(gameObject, 0.3f); 
            break;     
               
        }        
    }
}
