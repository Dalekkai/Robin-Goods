using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D sleeper;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "ThrownSpeer")
        {
            Destroy(gameObject);
            sleeper.gravityScale = 1;
            sleeper.constraints =  RigidbodyConstraints2D.None;
            sleeper.constraints =  RigidbodyConstraints2D.FreezePositionX;


        }
    }
}
