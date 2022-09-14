using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCheck : MonoBehaviour
{
    public EnemyHealthSystem hs;


    //Checks if the boss is dead to open the door to next lvl
    void Update()
    {
        if(hs.isDead){Destroy(gameObject);}
    }
}
