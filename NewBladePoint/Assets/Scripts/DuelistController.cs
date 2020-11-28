using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelistController : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public Animator myAnimator;
    public Animator fireAnim;
  
    public Animator leftAnim, rightAnim; //if necessary
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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetTrigger("Stab");
            //set the thing
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myAnimator.SetTrigger("Fire");
            fireAnim.SetTrigger("flameOn");
        }
      
        if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                myAnimator.SetTrigger("Kick");
            }

        if (left && Input.GetKeyDown(KeyCode.RightArrow))
        {
            left = false;
            //animation plays and location/orientation changes
        }

        if (!left && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left = true;
            //animation plays and location/orientation changes
        }
    }
    
    //currently, all of these simply play their animations

    public void Stab()
    {
        myAnimator.SetTrigger("Stab");
    }

    public void FireBreath()
    {
        myAnimator.SetTrigger("Fire");
    }

    public void Block()
    {
        myAnimator.SetTrigger("Block");
    }
    public void Kick()
    {
        myAnimator.SetTrigger("Kick");
    }
}
