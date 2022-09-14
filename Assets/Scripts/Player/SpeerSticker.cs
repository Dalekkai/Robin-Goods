using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeerSticker : MonoBehaviour
{

    public Rigidbody2D rb;

     //Prevents the speer from sticking in the air.
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Rope")return;
        rb.Sleep();
    }
    
}
