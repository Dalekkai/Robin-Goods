using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{

    public Animator animator;
    public GameObject orb;
    public GameObject player;
    public GameObject playerHolder;
    bool touchGround = false;

    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);

        //if click on orb is done do the following method
        PlayerFloating();
    }

    public void PlayerFloating()
    {
        orb.SetActive(false);
        playerHolder.SetActive(false);
        player.SetActive(true);
        //if(player touches ground) {touchGround = true; animator.SetBool("TouchGround", true);}
    }
}

