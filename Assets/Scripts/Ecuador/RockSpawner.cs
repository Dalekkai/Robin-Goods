using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject rockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRock();
    }

    void SpawnRock()
    {
        Instantiate(rockPrefab, gameObject.transform.position, Quaternion.identity);
        Invoke("SpawnRock", 2);
    }
}
