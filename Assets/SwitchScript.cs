﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour 
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D()
    {
        anim.SetBool("GoDown", true);
    }

    void OnTriggerExit2D()
    {
        anim.SetBool("GoDown", false);
    }

}
