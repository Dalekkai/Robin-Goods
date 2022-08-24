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

    // Update is called once per frame
    void Update()
    {

    }
    
    public void Shoot() //Shoots bullets at the faced direction 
                        //TODO shoots only to the left side
                        //Cannot use ShotTime for some reason. Hard code fix :P
    {
        GameObject BulletIns = Instantiate
        (bullet, firePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().velocity = -transform.right *force;
        Invoke("Shoot", 3);
    }
}
