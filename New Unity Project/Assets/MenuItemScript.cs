﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuItemScript : MonoBehaviour
{
    public Color hoverColor;
    public Color baseColor;
    public Image background;

    // Start is called before the first frame update
    void Start()
    {
        background.color = baseColor;
    }

    // Update is called once per frame
    public void Select()
    {
        background.color = hoverColor;
    }
    public void Deselect()
    {
        background.color = baseColor;
    }

    public static implicit operator MenuItemScript(int v)
    {
        return new MenuItemScript();
    }
}
