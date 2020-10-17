using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreDisplay;

    void Start()
    {
        score = 0;
        scoreDisplay = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreDisplay.text = score.ToString();
    }
}
