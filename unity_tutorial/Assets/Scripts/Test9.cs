﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test9 : MonoBehaviour
{

    ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ps.Emit(100);
    }
}
