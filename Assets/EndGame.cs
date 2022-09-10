using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EndOfGame");
    }

    public IEnumerator EndOfGame()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
        Debug.Log("GameQuit");
    }
}
