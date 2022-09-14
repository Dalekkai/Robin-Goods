using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public GameObject TriggerText;
    public CanvasGroup can;

    //Lets the player pick the item up and shows it in the Canvasgroup
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            can.alpha = 1f;
            TriggerText.SetActive(false);
        }
    }

}
