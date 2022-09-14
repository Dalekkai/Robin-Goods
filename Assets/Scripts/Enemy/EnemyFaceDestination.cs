using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyFaceDestination : MonoBehaviour
{
    public AIPath aiPath;

    // This scripts is from a YouTube tutorial
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale  = new Vector3(-1f,1f,1f);
        }
        else if(aiPath.desiredVelocity.x <= -0.01f)
         {
            transform.localScale  = new Vector3(1f,1f,1f);
        }
    }
}
