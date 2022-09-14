using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public Rigidbody2D door;

    //Lets the target fall down and the "door" float up when speer hits
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "ThrownSpeer")
        {
            door.gravityScale = -1;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
