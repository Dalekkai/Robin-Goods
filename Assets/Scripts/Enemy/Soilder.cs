using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soilder : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float force;
    public float shotTime;





    void Start()
    {
        Shoot();
    }

    //Shoots bullets to the left side to allow attacking from behind
    //Cannot use ShotTime for some reason. Hard code fix :P
    public void Shoot() 
    {
        GameObject BulletIns = Instantiate
        (bullet, firePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().velocity = -transform.right *force;
        Invoke("Shoot", 3);
    }
}
