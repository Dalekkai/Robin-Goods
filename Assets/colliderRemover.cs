using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderRemover : MonoBehaviour
{
    public Collider2D coll;

    public Collider2D coll2;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(coll, 14f);
        if(coll2 != null) Destroy(coll2, 14f);
    }
}
