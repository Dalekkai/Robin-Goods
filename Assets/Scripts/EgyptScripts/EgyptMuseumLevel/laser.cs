using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public GameObject laserLight;
    public GameObject laserBeam;
    public GameObject pos;

    void Start()
    {
        LaserLoop();
    }

    //Loops the laser logic
    private void LaserLoop()
    {
        Invoke("Warn", 1f);
        Invoke("Shoot", 2f);
        Invoke("LaserLoop", 3);
    }

    //Shows that the laser is about to beam
    private void Warn()  
    {
        Instantiate(laserBeam, transform.position, transform.rotation);
    }

    //Shoots the deadly laser
    private void Shoot()  
    {
        Debug.Log("Shoot");
        Instantiate(laserLight, pos.transform.position, transform.rotation);
    }
}
