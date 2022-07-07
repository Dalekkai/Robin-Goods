using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    public GameObject orb;
    public GameObject player;
    public GameObject playerHolder;
    public GameObject dialogueBoxTwo;

    public void ButtonPush()
    {
        StartCoroutine(PlayerFloating());
    }

    IEnumerator PlayerFloating()
    {
        orb.SetActive(false);
        dialogueBoxTwo.SetActive(true);

        yield return new WaitForSeconds(1);

        player.SetActive(true);
        playerHolder.SetActive(false);
    }
    
}

