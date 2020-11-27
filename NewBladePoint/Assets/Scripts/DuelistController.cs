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
            
        }

        if (!left && Input.GetKey(KeyCode.LeftArrow))
        {
            
        }
    }
}
