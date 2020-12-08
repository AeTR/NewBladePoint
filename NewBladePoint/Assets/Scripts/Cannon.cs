using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Player myPlayer;

    public GameManager myGM;

    public SpriteRenderer mySpriteRenderer;

    public Sprite ashSprite;

    public GameObject explosionBase;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GameObject.Find("Player Object").GetComponent<Player>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Contains("Enemy"))
        {
            myPlayer.currentDuelist.myAnimator.SetTrigger("No");
            mySpriteRenderer.sprite = ashSprite;
            explosionBase.SetActive(true);
        }
    }

    public void BlowUp()
    {
        myGM.RestartCurrentLevel();
    }
}
