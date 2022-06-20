using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public void LoadLevel(int level) //Loads a the next level with the index passed
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

        public static void Respawn() //Loads the current level again
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
