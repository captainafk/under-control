using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Result and Target gameobjects in the scene
    public GameObject result;

    public GameObject target;

    // The number player interacts
    private TMPro.TextMeshProUGUI resultTextObj;

    // The number player wants to achieve
    private TMPro.TextMeshProUGUI targetTextObj;

    // Start is called before the first frame update
    private void Start()
    {
        resultTextObj = result.GetComponentsInChildren<TextMeshProUGUI>()[1];
        targetTextObj = target.GetComponentsInChildren<TextMeshProUGUI>()[1];
    }

    // Update is called once per frame
    private void Update()
    {
    }
}