﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    // Axis

    public static float MainHorizontal()
    {
        float r = 0.0f;
        r += Input.GetAxis("C_MainHorizontal");
        r += Input.GetAxis("KB_MainHorizontal");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }
    public static float MainVertical()
    {
        float r = 0.0f;
        r += Input.GetAxis("C_MainVertical");
        r += Input.GetAxis("KB_MainVertical");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }

    public static Vector3 MainController()
    {
        return new Vector3(MainHorizontal(), 0, MainVertical());
    }

    // Buttons

    public static bool AButton()
    {
        return Input.GetButtonDown("A_Button");
    }

    public static bool BButton()
    {
        return Input.GetButtonDown("B_Button");
    }

    public static bool XButton()
    {
        return Input.GetButtonDown("X_Button");
    }

    public static bool YButton()
    {
        return Input.GetButtonDown("Y_Button");
    }

    public static bool RBButton()
    {
        return Input.GetButtonDown("RB_Button");
    }

    public static bool SelectButton()
    {
        return Input.GetButtonDown("Select_Button");
    }

    public static bool LBButton()
    {
        return Input.GetButtonDown("LB_Button");
    }
}
