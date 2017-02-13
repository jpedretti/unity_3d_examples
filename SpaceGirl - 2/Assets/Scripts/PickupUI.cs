﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupUI : MonoBehaviour {

    public GameObject starYellow;
    public GameObject starGrey;

    private void Awake()
    {
        DisplayEmpty();
    }

    public void DisplayYellow()
    {
        starYellow.SetActive(true);
        starGrey.SetActive(false);
    }

    public void DisplayGrey()
    {
        starYellow.SetActive(false);
        starGrey.SetActive(true);
    }

    public void DisplayEmpty()
    {
        starYellow.SetActive(false);
        starGrey.SetActive(false);
    }
}
