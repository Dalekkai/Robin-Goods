using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{

    public GameObject Hat; 
    bool hatThere = false;

    //Spawns the Hat when trigger is entered
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player" && !hatThere)
        {
            Instantiate(Hat, transform.position, transform.rotation);
            hatThere = true;
        }
    }
}
