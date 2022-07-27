using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter2D(Collider2D other) //Destroys the bullet after impact
    {
        switch(other.gameObject.tag)
        {
            case "Player":
            Destroy(gameObject, 0.3f); 
            break;     
               
        }        
    }
}
