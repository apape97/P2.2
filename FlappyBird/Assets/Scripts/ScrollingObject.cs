﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        rb2d.velocity = new Vector2(-4f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb2d.velocity);
    }
}
