using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnable : MonoBehaviour
{
    //Activates the shoot function in PlayerAttack
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerAttack>().fightType = 1;
        }
    }
}
