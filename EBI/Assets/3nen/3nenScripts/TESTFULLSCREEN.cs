﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTFULLSCREEN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Screen.fullScreen)
        {
            Screen.SetResolution(
                Screen.width,
                Screen.height,
                Screen.fullScreen);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
