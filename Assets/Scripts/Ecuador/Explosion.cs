using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Destroys the explosion after 0.4 secs to prevent player form getting damage
    //longer then needed
    void Start()
    {
        Destroy(gameObject, 0.4f);
    }

}
