using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameManager myGM;
    
    // Start is called before the first frame update
    void Start()
    {
        myGM = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void BlowUp()
    {
        myGM.RestartCurrentLevel();
    }
}
