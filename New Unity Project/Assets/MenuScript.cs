﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public Vector2 normalisedMousePosition;
    public float currentAngle;
    public int selection;
    public int previousSelection;

    public GameObject[] menuItems;

    private MenuItemScript menuItemSc;
    private MenuItemScript previousmenuItemSc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        normalisedMousePosition = new Vector2(Input.mousePosition.x - Screen.width / 2, Input.mousePosition.y - Screen.height / 2);
        currentAngle = Mathf.Atan2(normalisedMousePosition.y, normalisedMousePosition.x) * Mathf.Rad2Deg;

        currentAngle = (currentAngle + 360) % 360;

        selection = (int) currentAngle / 45;

        if (selection != previousSelection)
        {
            previousmenuItemSc = menuItems[selection].GetComponent<MenuItemScript>();
            previousmenuItemSc.Deselect();
            previousmenuItemSc = selection;

            menuItemSc = menuItems[selection].GetComponent<MenuItemScript>();
            menuItemSc.Select();
        }



        Debug.Log(selection);
    }

}

