using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool movingLeft, stunned;

    public float moveSpeed;

    public Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!stunned)
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
}
