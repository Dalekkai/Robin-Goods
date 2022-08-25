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

    public GameObject speer;
    
    public GameObject speerRB;

    public Transform throwpoint;

    public Transform speerPoint;

    bool canThrowAgain = true;

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

    void SpeerAttack()
    {
        if(speer == null) return;
        if(canThrowAgain)
        {
            //Instatiates the Prefab with Rb
            GameObject SpeerIns = Instantiate
            (speerRB, throwpoint.position, Quaternion.identity);

            //Prevents from bein scaled to big
            SpeerIns.transform.localScale = new Vector3(6,0.1f,2);

            //Adds a impulse to the right side of the warrior
            Vector2 direction = transform.right + new Vector3(0, 0.1f, 0);
            SpeerIns.GetComponent<Rigidbody2D>().AddForce(direction * Force, ForceMode2D.Impulse);
           
            //Lets you throw after 3 seconds again
            canThrowAgain = false;
            Invoke("LetThrowAgain", 3); 
            
        }
        
    }

    void Shoot()
    {
        GameObject BulletIns = Instantiate
        (playerBullet, firePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(transform.right * 20, ForceMode2D.Impulse);
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

    void LetThrowAgain()
    {
        //Instatiate Speer to make clear the speere can be thrwon again 
        canThrowAgain = true;
        Instantiate(speer, speerPoint);
    }
}
