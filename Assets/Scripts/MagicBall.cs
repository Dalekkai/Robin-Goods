using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBall : MonoBehaviour
{

    public float speed = 1f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //move right according to the speed
        rb.velocity = transform.right * speed;
    }

}
