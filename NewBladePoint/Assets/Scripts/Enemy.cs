using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player myPlayer;
    public GameManager myGM;
    public AudioClip deathSound;
    public bool movingLeft, stunned;

    public float moveSpeed;

    public Animator myAnimator;

    public ParticleSystem burst;

    public float deathTime = .3f;

    public bool die = false;

    public bool prepping;

    public SpriteRenderer mySpriteRenderer;

    public GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GameObject.Find("Player Object").GetComponent<Player>();
        myGM = GameObject.Find("Game Manager").GetComponent<GameManager>();
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void FixedUpdate()
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
        
        myGM.mySource.PlayOneShot(deathSound);
        mySpriteRenderer.enabled = false;
        stunned = true;
        Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(gameObject, particles.GetComponent<ParticleSystem>().main.duration);
        myPlayer.KillConfirm();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
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
