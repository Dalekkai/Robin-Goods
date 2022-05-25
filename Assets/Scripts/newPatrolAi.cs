using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPatrolAi : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D rb2d;
    BoxCollider2D bc2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isFacingRight())
        {
            rb2d.velocity = new Vector2(moveSpeed, 0f);
        } else
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0f);
        }
    }

    private void OnTriggerExit2D(Collider2D other) //Simple way of fliping the character using 
                                                   //mathf instead of hardcoding -1 & 1
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rb2d.velocity.x)), 
        transform.localScale.y);
    }

    private bool isFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon; //Epsilon is cleaner than 0.000f
    }
}
