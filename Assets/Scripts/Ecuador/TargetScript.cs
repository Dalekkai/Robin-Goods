using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public Rigidbody2D door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "ThrownSpeer")
        {
            //Makes the Door float upwards and the target come down if hit by a speer.
            door.gravityScale = -1;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
