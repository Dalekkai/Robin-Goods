using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Hello");
            SceneManager.LoadScene(1);
        }   
    }
}
