using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDestroyer : MonoBehaviour
{
    // Destroy the object on bullet impact and spawn particle system and sound
    // TODO Particle sytem and audioclip play
    public ParticleSystem glassShatters;
    public AudioSource Crash;


    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
            glassShatters.Play();
            Crash.Play();
        }    
    }

}
