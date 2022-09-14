using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject rockPrefab;

    // Spawns the bomb after a random time between 0 and 1.5 secs
    void Start()
    {
        Invoke("SpawnRock", Random.Range(0f, 1.5f));

    }

    //Spawns the Bomb and loops 
    void SpawnRock()
    {
        Instantiate(rockPrefab, gameObject.transform.position, Quaternion.identity);
        Invoke("SpawnRock", 2);
    }
}
