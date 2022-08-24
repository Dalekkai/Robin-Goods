using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject playerBullet;
    public float Force;

    public Animator animator;

    public int fightType = 0;

    public Transform sword;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            switch(fightType)
            {
                case 0:
                break;

                case 1:
                Shoot();
                break;

                case 2:
                MeleAtack();
                break;

                case 3:
                SpeerAttack();
                break;

                default:
                break;

            }

        }
    }

    private void SpeerAttack() // TODO 
    {
        throw new NotImplementedException();
    }

    void Shoot()
    {
        GameObject BulletIns = Instantiate
        (playerBullet, firePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().velocity = transform.right * Force;
    }

    void MeleAtack()
    /*
    1. Plays the animation.
    2. Sets the Tag of the sword to "sword" for one second. 
       The tag is checked in the PlayerHealth script to cause dmg.
    */
    {
        if(sword == null) return;

        animator.SetTrigger("Attack");
        sword.gameObject.tag = "Sword";
        Invoke("MeleDmgCancle", 1);
    }

    void MeleDmgCancle() //Changes the sword tag back to make it non dmg. 
    {
        sword.gameObject.tag ="Untagged";
    }
}
