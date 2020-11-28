using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public GameObject[] clouds;
    public float dist;
    public float maxDist;
    public float moveSpd;
    
    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < clouds.Length; i++)
        {
            if (clouds[i].transform.position.x>=maxDist)
            {
                if (i<clouds.Length-1)
                {
                    clouds[i].transform.position = new Vector3(clouds[i+1].transform.position.x-dist,0, 2);
                }
                else
                {
                    clouds[i].transform.position = new Vector3(clouds[0].transform.position.x-dist,0, 2);
                }
            }
            clouds[i].transform.position += new Vector3(moveSpd*Time.deltaTime, 0, 0);
        }
        
    }
}
