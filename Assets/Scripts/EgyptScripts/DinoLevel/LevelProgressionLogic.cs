using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProgressionLogic : MonoBehaviour
{
    bool gotTool = false;

    private void OnTriggerEnter2D(Collider2D other) {
        switch(other.tag)
        {
            case "Tool":
            gotTool = true;
            break;

            case "Vent":
            if(gotTool){LevelLoader.LoadNextLevel();}
            break;

            default:
            break;
        }
    }
}
