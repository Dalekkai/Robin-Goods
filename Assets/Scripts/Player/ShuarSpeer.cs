using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuarSpeer : MonoBehaviour
{
    // Start is called before the first frame update
    bool hasBeenThrown = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasBeenThrown)
        {
            Destroy(gameObject, 10f);
        }
    }
}
