using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolScript : MonoBehaviour
{
    [HideInInspector] 
    public bool mustPatrol; //The bool to make the character patroling or stopping
    private bool mustTurn;
    public Rigidbody2D rb2d; //The rigidbody of the enemy to move 
    //public Transform groundCheckPos; //Reference to the ground checking object
    public LayerMask groundLayer;
    public float walkSpeed = 1000f; //The walking speed of the enemy

    void Start()
    {
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(mustPatrol)
        {
            Patrol();
        }
    }

/*      private void FixedUpdate() //Checks if the ground check circle touches the ground
    {
        if(mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer); 
        }
    } */

    void Patrol()
    {
      /*   if (mustTurn)
        {
            Flip();
        } */
        rb2d.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb2d.velocity.y);
    }

/*     void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *=-1;
        mustPatrol = true;
    } */

}