using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BustPlacer : MonoBehaviour
{
    // TODO Load next level, Destroy trigger once placed
    public GameObject bust;
    public CanvasGroup cg;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Instantiate(bust, gameObject.transform.position, gameObject.transform.rotation);
        cg.alpha = 0f;
        Invoke("loadLevel", 2f);

    }

    void loadLevel()
    {
        LevelLoader.LoadNextLevel();
    }
}
