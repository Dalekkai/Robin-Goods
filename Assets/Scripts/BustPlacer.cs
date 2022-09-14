using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BustPlacer : MonoBehaviour
{

    public GameObject bust;
    public CanvasGroup cg;

    //Hides the artefact on canvas and places it. Loads next lvl after 2 secs
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Instantiate(bust, gameObject.transform.position, 
        gameObject.transform.rotation);
        cg.alpha = 0f;
        Invoke("loadLevel", 2f);

    }

    void loadLevel()
    {
        LevelLoader.LoadNextLevel();
    }
}
