using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject playerBullet;
    public float Force;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject BulletIns = Instantiate
        (playerBullet, firePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().velocity = transform.right * Force;
    }
}
