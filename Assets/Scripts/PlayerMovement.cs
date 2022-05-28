using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    private float wallJumpCooldown;
    private float horizontalInput;

    
    //awake is called everytime the script is loaded
    private void Awake()
    {
        //grab references from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    //on every frame of the game the input is recorded so the player moves while pressing keys
    private void Update()
    {
        //stores  Input.GetAxis 
        horizontalInput = Input.GetAxis("Horizontal");

        //let player flip left and right when moving
        if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        //Set animator parameters
        anim.SetBool("grounded", isGrounded());

        //Wall Jump logic
        if(wallJumpCooldown > 0.2f)
        {
           
            //first is left right movement, second up and down movement 
            body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

            if (onWall() && !isGrounded())
            {
                body.gravityScale = 0;
                body.velocity = Vector2.zero;
            } else
            {
                body.gravityScale = 2;
            }
            //let player jump when he presses the space key
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        }
        else
        {
            wallJumpCooldown += Time.deltaTime;
        }
    }

    private void Jump()
    {
        if (isGrounded()) { 

        body.velocity = new Vector2(body.velocity.x, jumpPower);
        anim.SetTrigger("jump");

        } else if (onWall() && !isGrounded())
        {
            if (horizontalInput == 0)
            {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            } else
            {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
            }
            wallJumpCooldown = 0;
            
        }
    }

    //this method will tell if player is grounded
    private bool isGrounded()
    { 
        //first one in BoxCast is origin of the box, second one is the size of it, third is angle to rotate
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    private bool onWall()
    {
        //first one in BoxCast is origin of the box, second one is the size of it, third is angle to rotate
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycastHit.collider != null;
    }

    //defines when player can attack
    public bool canAttack ()
    {
        return horizontalInput == 0 && isGrounded() && !onWall();
    }
}
