using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderRemover : MonoBehaviour
{
    public Collider2D coll;

    public Collider2D coll2;
    // Removes the collider that prevent slipping
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(coll, 14f);
        if(coll2 != null) Destroy(coll2, 14f);
    }
}
