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
    private UnderControl.Number number;
    public Slider timeSlider;

    // An integer for making sure an interaction happens only once
    private static int interactOnlyOnce;

    // Result and Target gameobjects in the scene
    public GameObject result;

    public GameObject target;

    // The number player interacts
    private TextMeshProUGUI resultTextObj;

    // The number player wants to achieve
    private TextMeshProUGUI targetTextObj;

    // Boundaries of the target range
    private int minRange = -10;

    private int maxRange = 20;

    private void Start()
    {
        // Consturct a number object with the number in its text
        TextMeshProUGUI text = gameObject.GetComponent<TextMeshProUGUI>();
        numberValue = Convert.ToInt32(text.text);
        number = new UnderControl.Number(numberValue);

        // Initialize the number with active summation
        number.ActivateOperation(UnderControl.Number.Operations.Summation);

        // Initialize interactOnlyOnce with 1
        interactOnlyOnce = 1;

        // Assign result and target text objects
        resultTextObj = result.GetComponentsInChildren<TextMeshProUGUI>()[1];
        targetTextObj = target.GetComponentsInChildren<TextMeshProUGUI>()[1];

        // Initialize target number with something between -10 and 20
        targetTextObj.text = UnityEngine.Random.Range(minRange, maxRange).ToString();
    }

    private void Update()
    {
        // Interact with result when slider hits
        if (timeSlider.value > 10.0f && interactOnlyOnce == 1 && numberValue == 1)
        {
            resultTextObj.text = number.InteractWithResult(Convert.ToInt32(resultTextObj.text)).ToString();
            interactOnlyOnce++;
        }
        else if (timeSlider.value > 30.0f && interactOnlyOnce == 2 && numberValue == 2)
        {
            resultTextObj.text = number.InteractWithResult(Convert.ToInt32(resultTextObj.text)).ToString();
            interactOnlyOnce++;
        }
        else if (timeSlider.value > 50.0f && interactOnlyOnce == 3 && numberValue == 3)
        {
            resultTextObj.text = number.InteractWithResult(Convert.ToInt32(resultTextObj.text)).ToString();
            interactOnlyOnce++;
        }
        else if (timeSlider.value > 70.0f && interactOnlyOnce == 4 && numberValue == 4)
        {
            resultTextObj.text = number.InteractWithResult(Convert.ToInt32(resultTextObj.text)).ToString();
            interactOnlyOnce++;
        }
        else if (timeSlider.value > 90.0f && interactOnlyOnce == 5 && numberValue == 5)
        {
            resultTextObj.text = number.InteractWithResult(Convert.ToInt32(resultTextObj.text)).ToString();
            interactOnlyOnce++;
        }
        else if (timeSlider.value < 10.0f && interactOnlyOnce == 6)
        {
            interactOnlyOnce = 1;
        }

        // Asign a new target if the target is met
        if (resultTextObj.text == targetTextObj.text)
        {
            targetTextObj.text = UnityEngine.Random.Range(minRange, maxRange).ToString();
            minRange -= 5;
            maxRange += 5;
            ScoreObject.score++;
        }
    }

    public void ActivateOperation(int opIndex)
    {
        number.ActivateOperation((UnderControl.Number.Operations)opIndex);
    }
}