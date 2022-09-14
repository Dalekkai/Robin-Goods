using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDestroyer : MonoBehaviour
{

    public ParticleSystem glassShatters;
    public AudioSource Crash;

    // Destroys the object on weapon impact and spawn particle system and sound
    private void OnTriggerEnter2D(Collider2D other) 
    {

        switch (other.gameObject.tag)
        {
            case "PlayerBullet":
            Destroy(gameObject);
            glassShatters.Play();
            Crash.Play();
            break;

            case "Sword":
            Destroy(gameObject);
            glassShatters.Play();
            Crash.Play();
            break;

            case "ThrownSpeer":
            Destroy(gameObject);
            glassShatters.Play();
            Crash.Play();
            break;
        }
    }

}
