using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    private Animator anim;
    private PlayerMovement playerMovement;
    //makes sure the player can attack right away when the game starts
    private float cooldownTimer = Mathf.Infinity;

    //awake is called everytime the script is loaded
    private void Awake()
    {
        //grab references from object
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

     private void Update()
    {
        //checks if left mouse button is pressed
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
        {
            Attack();
        }
        cooldownTimer += Time.deltaTime;
    }
    private void Attack()
    {
        //animation not ready yet
        //anim.SetTrigger("Attack");
        cooldownTimer = 0;
    }
}
