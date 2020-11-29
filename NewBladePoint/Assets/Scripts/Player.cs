using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DuelistController leftDuelist, rightDuelist, currentDuelist;
    // Start is called before the first frame update
    void Start()
    {
        currentDuelist = rightDuelist;
        leftDuelist.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDuelist == rightDuelist && Input.GetKeyDown(KeyCode.LeftArrow) && currentDuelist.myState == DuelistController.DuelistState.Idle)
        {
            //switch to left
            leftDuelist.gameObject.SetActive(true);
            currentDuelist = leftDuelist;
            rightDuelist.gameObject.SetActive(false);
        }

        if (currentDuelist == leftDuelist && Input.GetKeyDown(KeyCode.RightArrow) && currentDuelist.myState == DuelistController.DuelistState.Idle)
        {
            //switch to right
            rightDuelist.gameObject.SetActive(true);
            currentDuelist = rightDuelist;
            leftDuelist.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentDuelist.FireBreath();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentDuelist.Block();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Finn did the press/hold thing in an interesting way, I haven't put it in yet.
            currentDuelist.Stab();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            currentDuelist.Kick();
        }
        
        
    }
}
