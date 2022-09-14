using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtefactScript : MonoBehaviour
{
    // Loads the next level when artefact is reached
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            LevelLoader.LoadNextLevel();
        }
    }
}
