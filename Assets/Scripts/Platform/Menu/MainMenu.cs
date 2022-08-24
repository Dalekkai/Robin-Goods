using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        LevelLoader.LoadNextLevel();
    }

    public void LoadGame()
    {
        //TODO Load last Scene
        LevelLoader.LoadLevel(PlayerPrefs.GetInt("Scene"));
    }

    public void QuitGame()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
