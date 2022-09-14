using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScripts : MonoBehaviour
{

    public Rigidbody2D sleeper;

    //Destorys the rope and lets the Platform fall down
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "ThrownSpeer")
        {
            Destroy(gameObject);
            sleeper.gravityScale = 1;
            sleeper.constraints =  RigidbodyConstraints2D.None;
            sleeper.constraints =  RigidbodyConstraints2D.FreezePositionX;
            sleeper.constraints =  RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
