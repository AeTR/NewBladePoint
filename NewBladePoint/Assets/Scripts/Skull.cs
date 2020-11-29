using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!stunned)
        {
            Move();
        }
    }
    
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
