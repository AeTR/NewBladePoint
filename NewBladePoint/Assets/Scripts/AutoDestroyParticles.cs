﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyParticles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, GetComponent<ParticleSystem>().main.duration); 
    }
}
