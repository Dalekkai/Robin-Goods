using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0 ,0) *Time.deltaTime * speed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb2d.velocity.y) < 0.001f)
        {
            rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
