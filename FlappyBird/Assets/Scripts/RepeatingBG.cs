﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{

    private BoxCollider2D groundCollider;
    private float groundHorzLength;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D> ();
        groundHorzLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorzLength) {
            RepositionBG();
        }
    }

    private void RepositionBG() {
        Vector2 groundOffset = new Vector2(groundHorzLength*2f, 0);
        transform.position = (Vector2) transform.position + groundOffset;
    }
}
