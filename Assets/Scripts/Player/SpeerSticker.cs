using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeerSticker : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Rope")return; //Prevents the speer from sticking in the air.
        // Debug.Log("Stick");
        // rb.velocity = new Vector2(0,0);
        // rb.gravityScale = 0;
        rb.Sleep();
    }
    
}
