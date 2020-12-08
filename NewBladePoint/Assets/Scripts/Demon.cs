using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Demon : Enemy
{


    new public void OnTriggerEnter2D(Collider2D other)
    {
        print("haha lol");
        if (!stunned && other.CompareTag("attackParry"))
        {
            myAnimator.SetBool("Wobble", true);
            stunned = true;
        }

        if (stunned && other.CompareTag("attackStab"))
        {
            Die();
        }
    }
}
