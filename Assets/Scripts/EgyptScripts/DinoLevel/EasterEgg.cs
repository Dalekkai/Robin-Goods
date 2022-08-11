using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    //TODO: Spawn Hat png, play sound 
    public GameObject Hat; //The prefab will play the sound on awake --> no code soloution
    bool hatThere = false;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player" && !hatThere)
        {
            Instantiate(Hat, transform.position, transform.rotation);
            hatThere = true;
        }
    }
}
