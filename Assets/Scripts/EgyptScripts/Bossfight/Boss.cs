using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject bookBullet;
    public Transform firePoint;
    public float force;



    // TODO: Movement, Timing the shots, Healthbar, a check if dead.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Shoot() //Shoots books at the faced direction 
    {
        GameObject BulletIns = Instantiate
        (bookBullet, firePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().velocity = transform.right *force;
    }
}
