using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public static void LoadNextLevel() //Loads a the next level with the index passed
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        PlayerPrefs.SetInt("Scene", SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log(PlayerPrefs.GetInt("Scene"));
    }

        public static void Respawn() //Loads the current level again
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void LoadLevel(int level)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +level); 
    }
}
