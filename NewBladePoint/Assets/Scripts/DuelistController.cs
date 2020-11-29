using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelistController : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public Animator myAnimator;
    public Animator fireAnim;
  
    public Animator leftAnim, rightAnim; //if necessary
    public GameManager myGM;
    public bool left;

    public enum DuelistState
    {
        Idle,
        Charging,
        Blocking
    }

    public DuelistState myState;
    // Start is called before the first frame update
    void Start()
    {
        left = false;
    }

    //currently, all of these simply play their animations

    public void Stab()
    {
        tag = "attackStab";
        myAnimator.SetTrigger("Stab");
    }

    public void FireBreath()
    {
        tag = "attackFire";
        myAnimator.SetTrigger("Fire");
    }

    public void Block()
    {
        tag = "attackParry";
        myAnimator.SetTrigger("Block");
    }
    public void Kick()
    {
        tag = "attackKick";
        myAnimator.SetTrigger("Kick");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Contains("enemy") && !other.GetComponent<Enemy>().stunned)
        {
            //play death animation
            myGM.RestartCurrentLevel();
        }
    }
}
