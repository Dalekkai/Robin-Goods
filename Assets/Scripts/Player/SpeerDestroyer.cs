using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeerDestroyer : MonoBehaviour
{

    //Destroys the speer when thrown
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Destroy(gameObject);
        }
    }
}
