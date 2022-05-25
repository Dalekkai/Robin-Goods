using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    private Animator anim;
    private bool grounded;

    //awake is called everytime the script is loaded
    private void Awake()
    {
        //grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //on every frame of the game the input is recorded so the player moves while pressing keys
    private void Update()
    {
        //stores  Input.GetAxis 
        float horizontalInput = Input.GetAxis("Horizontal");

        //first is left right movement, second up and down movement 
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //let player flip left and right when moving
        if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        //let player jump when he presses the space key
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }

        //Set animator parameters
        anim.SetBool("grounded", grounded);
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpSpeed);
        anim.SetTrigger("jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }
}
