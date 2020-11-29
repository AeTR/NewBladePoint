using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool movingLeft, stunned;

    public float moveSpeed;

    public Animator myAnimator;

    public ParticleSystem burst;

    public float deathTime = .3f;

    public bool die = false;

    public bool prepping;

    public SpriteRenderer mySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        if (!stunned)
        {
            Move();
        }
      /*  if (die == true)
        {
            Debug.Log("tick tock");
            deathTime -= Time.deltaTime;
        }
        if (deathTime <= 0)
        {
           
        }*/

    }

    public void Move()
    {
        //Debug.Log("Moving");
        var transform1 = transform;
        var position = transform1.position;
        position.x = position.x - moveSpeed;
        if (movingLeft)
        {
            transform.Translate(-moveSpeed, 0f, 0f);
            //transform.TransformDirection(Vector3.left);
            position.x = position.x - moveSpeed;
        }
        else
        {
            position.x = position.x + moveSpeed;
        }
       
    }

    public void Die()
    {
        burst.Play();

        die = true;

        Destroy(gameObject);

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        print("haha lol");
        if (other.tag.Contains("attack"))
        {
            Die();
        }
    }

    public void Stun()
    {
        
    }

    public void Prepare(bool facingLeft)
    {
        if (facingLeft)
        {
            movingLeft = true;
        }
        else
        {
            movingLeft = false;
            mySpriteRenderer.flipX = true;
        }
        prepping = false;
    }
}
