using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : Enemy
{

    new public void OnTriggerEnter2D(Collider2D other)
    {
        print("haha lol");
        if (!stunned && other.CompareTag("attackKick"))
        {
            myAnimator.SetBool("badump", true);
            stunned = true;
        }

        if (stunned && other.CompareTag("attackStab"))
        {
            Die();
        }
    }
    
}
