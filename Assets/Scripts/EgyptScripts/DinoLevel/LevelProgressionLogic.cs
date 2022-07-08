using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProgressionLogic : MonoBehaviour
{
    bool gotTool = false;
    public CanvasGroup can;

    private void OnTriggerEnter2D(Collider2D other) {
        switch(other.tag)
        {
            case "Tool":
            gotTool = true;
            break;

            case "Vent":
            if(gotTool)
            {
                LevelLoader.LoadNextLevel();
                can.alpha = 0f;
            }
            break;

            default:
            break;
        }
    }
}
