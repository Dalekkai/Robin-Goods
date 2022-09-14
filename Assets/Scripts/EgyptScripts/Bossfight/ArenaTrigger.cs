using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaTrigger : MonoBehaviour
{
    //Loads the next level to enter the arena
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player"){LevelLoader.LoadNextLevel();}    
    }
}
