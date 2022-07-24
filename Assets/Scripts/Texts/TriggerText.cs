using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject player;
    public GameObject playerHold;
    public GameObject music;
    public GameObject sound;

    void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<PlayerAttack>().enabled = false;
            player.GetComponent<Animator>().enabled = false;
            music.SetActive(false);
            sound.SetActive(true);
            uiObject.SetActive(true);
            StartCoroutine("Text");
        }
    }

    IEnumerator Text()
    {
        yield return new WaitForSeconds(3);
        Destroy(uiObject);
        Destroy(gameObject);
        playerHold.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<PlayerAttack>().enabled = true;
        player.GetComponent<Animator>().enabled = true;
        music.SetActive(true);
        sound.SetActive(false);

    }
}
