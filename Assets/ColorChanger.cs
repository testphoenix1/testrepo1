﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
