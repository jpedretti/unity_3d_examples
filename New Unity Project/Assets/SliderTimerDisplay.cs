﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTimerDisplay : MonoBehaviour {

    private Slider sliderUI;
    private int startSeconds = 30;
    private CountdownTimer countdownTimer;

    void Start (){
        SetupSlider();
        SetupTimer();
    }
    void Update () {
        sliderUI.value =
            countdownTimer.GetProportionTimeRemaining();
        print (countdownTimer.GetProportionTimeRemaining());
    }
    private void SetupSlider (){
        sliderUI = GetComponent<Slider>();
        sliderUI.minValue = 0;
        sliderUI.maxValue = 1;
        sliderUI.wholeNumbers = false;
    }
    private void SetupTimer (){
        countdownTimer = GetComponent<CountdownTimer>();
        countdownTimer.ResetTimer(startSeconds);
    }
}
