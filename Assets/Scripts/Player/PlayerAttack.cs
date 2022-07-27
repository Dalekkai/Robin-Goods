using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject playerBullet;
    public float Force;
    public bool canShoot;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Shoot"){canShoot = true;}
    }
    void Shoot()
    {
        if(canShoot) //Checks if the ability is already learned.
        {
        GameObject BulletIns = Instantiate
        (playerBullet, firePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().velocity = transform.right * Force;
        }       
    }
}
