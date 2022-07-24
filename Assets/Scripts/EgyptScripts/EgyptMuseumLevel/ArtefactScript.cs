using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtefactScript : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        //TODO transition and dialouge 
        if(other.gameObject.tag == "Player")
        {
            LevelLoader.LoadNextLevel();
        }
    }
}
