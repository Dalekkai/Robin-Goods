using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLogicVent : MonoBehaviour
{
    //Loads the next level, when touched
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag =="Finish")
        {
            LevelLoader.LoadNextLevel();
        }
    }
}
