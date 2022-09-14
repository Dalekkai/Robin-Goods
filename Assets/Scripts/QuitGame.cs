using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    //Quits game when esc is pressed
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
