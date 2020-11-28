using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelistController : MonoBehaviour
{
    public bool left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
        }

        if (left && Input.GetKey(KeyCode.RightArrow))
        {
            left = false;
            //animation plays and location/orientation changes
        }

        if (!left && Input.GetKey(KeyCode.LeftArrow))
        {
            left = true;
            //animation plays and location/orientation changes
        }
    }
}
