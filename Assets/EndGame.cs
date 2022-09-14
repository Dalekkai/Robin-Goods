using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
 
    void Start()
    {
        StartCoroutine("EndOfGame");
    }

    public IEnumerator EndOfGame()
    {
        yield return new WaitForSeconds(13);
        SceneManager.LoadScene("Menu");
    }
}
