using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool movingLeft, stunned, prepping;

    public float moveSpeed;

    public Animator myAnimator;

    public SpriteRenderer mySpriteRenderer;

    public Player myPlayer;

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

    public void Move()
    {
        //Debug.Log("Moving");
        var transform1 = transform;
        var position = transform1.position;
        position.x = position.x - moveSpeed;
        if (movingLeft)
        {
            transform.Translate(-moveSpeed, 0f, 0f);
        }
        else
        {
            transform.Translate(moveSpeed, 0f, 0f);
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        myPlayer.KillConfirm();
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

    public void Prepare(bool amIFacingLeft)
    {
        if (amIFacingLeft)
        {
            movingLeft = true;
        }
        else
        {
            movingLeft = false;
            mySpriteRenderer.flipX = true;
        }

        myPlayer = GameObject.Find("Player Object").GetComponent<Player>();
        prepping = false;
    }
}
