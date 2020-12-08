using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DuelistController leftDuelist, rightDuelist, currentDuelist;
    public GameManager myGM;
    public int enemyGoal, currentKillNum;
    // Start is called before the first frame update
    void Start()
    {
        myGM = GameObject.Find("Game Manager").GetComponent<GameManager>();
        currentDuelist = rightDuelist;
        leftDuelist.gameObject.SetActive(false);
        currentKillNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDuelist == rightDuelist && Input.GetKeyDown(KeyCode.LeftArrow) && currentDuelist.mobile)
        {
            print("left");
            //switch to left
            leftDuelist.gameObject.SetActive(true);
            currentDuelist = leftDuelist;
            rightDuelist.gameObject.SetActive(false);
        }

        if (currentDuelist == leftDuelist && Input.GetKeyDown(KeyCode.RightArrow) && currentDuelist.mobile)
        {
            print("right");
            //switch to right
            rightDuelist.gameObject.SetActive(true);
            currentDuelist = rightDuelist;
            leftDuelist.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && currentDuelist.mobile)
        {
            print("up");
            currentDuelist.FireBreath();
            currentDuelist.fireAnim.SetTrigger("flameOn");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && currentDuelist.mobile)
        {
            print("down");
            currentDuelist.Block();
        }

        if (Input.GetKeyDown(KeyCode.Space) && currentDuelist.mobile)
        {
            print("space");
            //Finn did the press/hold thing in an interesting way, I haven't put it in yet.
            currentDuelist.Stab();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && currentDuelist.mobile)
        {
            print("shift");
            currentDuelist.Kick();
        }
    }

    public void KillConfirm()
    {
        currentKillNum++;
        if (currentKillNum >= enemyGoal)
        {
            myGM.Progress();
        }
    }

    public void PlayerLose()
    {
        print("aaa");
        myGM.RestartCurrentLevel();
    }
}
