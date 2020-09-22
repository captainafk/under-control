using Packages.Rider.Editor.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberFunc : MonoBehaviour
{
    private int numberValue;

    // Slider value -> Number Value
    // 10 -> 1
    // 30 -> 2
    // 50 -> 3
    // 70 -> 4
    // 90 -> 5
    public Slider timeSlider;
    void Start()
    {
        // Consturct a number object with the number in its text
        TextMeshProUGUI text = gameObject.GetComponent<TextMeshProUGUI>();
        numberValue = Convert.ToInt32(text.text);
        UnderControl.Number number = new UnderControl.Number(numberValue);

        // Initialize the number with active summation
        number.ActivateOperation(UnderControl.Number.Operations.Summation);

        
    }

    void Update()
    {
        
    }
}
