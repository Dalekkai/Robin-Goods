using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForText : MonoBehaviour
{
    public GameObject player;
    public GameObject dialogueBox;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            dialogueBox.SetActive(true);
        } 
    }
}

