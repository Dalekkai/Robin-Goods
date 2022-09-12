using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject rockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRock", Random.Range(0f, 1.5f));

    }

    void SpawnRock()
    {
        Instantiate(rockPrefab, gameObject.transform.position, Quaternion.identity);
        Invoke("SpawnRock", 2);
    }
}
