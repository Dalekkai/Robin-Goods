using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserRemover : MonoBehaviour
{
    public float timeToDestroy;

    //Destroys the laser after timeToDestroy
    private void Start() 
    {
        Destroy(gameObject, timeToDestroy);    
    }
}
