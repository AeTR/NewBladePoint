using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public DuelistController myDuelist;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Contains("Enemy") && !other.gameObject.GetComponent<Enemy>().stunned)
        {
            myDuelist.Die();
        }
    }
}
