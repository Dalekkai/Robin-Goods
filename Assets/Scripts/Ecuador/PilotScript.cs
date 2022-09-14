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


    void Update()
    {
        LookAtPlayer();
    }

    //Lets the pilot look at the player by changing the scale on the y axe
        public void LookAtPlayer() 
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

    //Adds smoke effects after the first and second hit
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
