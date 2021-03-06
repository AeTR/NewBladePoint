﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : Enemy
{
    public bool movingUp;

    public float upDownSpeed;
    // Start is called before the first frame update
    void Start()
    {
        myGM = GameObject.Find("Game Manager").GetComponent<GameManager>();
        movingUp = false;
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    new public void Move()
    {

        if (!myAnimator.GetBool("Squishing"))
        {
            if (movingLeft)
            {
                if (movingUp)
                {
                    transform.Translate(-moveSpeed, upDownSpeed, 0f);
                }
                else
                {
                    transform.Translate(-moveSpeed, -upDownSpeed, 0f);
                }
            }
            else
            {
                if (movingUp)
                {
                    transform.Translate(moveSpeed, upDownSpeed, 0f);
                }
                else
                {
                    transform.Translate(moveSpeed, -upDownSpeed, 0f);
                }
            }
        }
        if (transform.position.y <= -3.75f)
        {
            myAnimator.SetBool("Squishing", true);
            movingUp = true;
        }

        if (transform.position.y >= 1f)
        {
            movingUp = false;
        }
    }

    new public void OnTriggerEnter2D(Collider2D other)
    {
        print("haha lol");
        if (other.CompareTag("attackFire"))
        {
            Die();
        }
    }
}
