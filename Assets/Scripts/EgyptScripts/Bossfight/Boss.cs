using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject bookBullet;
    public Transform firePoint;
    public float force;
    public float shotTime;
    public Transform player;
    public bool isFlipped = false;

    public float speed = 0.1f;

    Rigidbody2D rb;




    // TODO: Healthbar scale, a check if dead.
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Shoot();

    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        Run();
    }
    
    public void Shoot() //Shoots books at the faced direction 
    {
        GameObject BulletIns = Instantiate
        (bookBullet, firePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().velocity = -transform.right *force;
        Invoke("Shoot", shotTime);
    }

    public void LookAtPlayer() //Changes the scale to look at player. Used in the Animatior Script.
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if(transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if(transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }

    void Run()
    {
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);
    }
}
