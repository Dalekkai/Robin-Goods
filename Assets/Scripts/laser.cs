using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public GameObject laserLight;
    public GameObject laserBeam;
    public GameObject pos;
    // TODO death
    void Start()
    {
        LaserLoop();
    }

    private void LaserLoop()
    {
        Debug.Log("Start laserloop");
        Invoke("Warn", 1f);
        Invoke("Shoot", 2f);
        Invoke("LaserLoop", 3);
    }

    private void Warn() // 
    {
        Instantiate(laserBeam, transform.position, transform.rotation);
    }
    private void Shoot() // 
    {
        Debug.Log("Shoot");
        Instantiate(laserLight, pos.transform.position, transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
