using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuarSpeer : MonoBehaviour
{
    //Destroys the speer after 3 secs 
    void Start()
    {

        Destroy(gameObject, 3f);
    }

}
