﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Demon : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!stunned && !prepping)
        {
            Move();
        }
    }

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
