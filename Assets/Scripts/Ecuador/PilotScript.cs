using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotScript : MonoBehaviour
{
    public Transform player;

    public bool isFlipped = false;

    public ParticleSystem smoke;
    public ParticleSystem smoke1;
     

    private int damage = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
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

    private void OnTriggerEnter2D(Collider2D other) 
    {
        AddSmoke();
    }

    void AddSmoke()
    {
        
        if(damage == 0)
        {
            smoke.Play();

        }
        else if(damage== 1)
        {
            smoke1.Play();
        }
        damage ++;
    }
}
