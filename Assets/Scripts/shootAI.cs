using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAI : MonoBehaviour
{
    public Transform player;
    public float range;
    public float timeBTWshots;
    private float distTPlayer;
    bool shotReady = true;
    public GameObject bulletPrefab;

    void Update()
    {
        distTPlayer = Vector2.Distance(transform.position, player.position);
        if (distTPlayer <= range)
        {
           StartCoroutine(Shoot());             
        }
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(timeBTWshots);
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

}
