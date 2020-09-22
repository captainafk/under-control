using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSlider : MonoBehaviour
{
    [SerializeField]
    private float sliderSpeed = 5.0f;
    private Slider slider;
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    void Update()
    {
        slider.value += sliderSpeed * Time.deltaTime;
        
        // When slider reaches 100%, return to 0 and increase the speed
        if (slider.value >= 100.0f)
        {
            slider.value = 0.0f;
            sliderSpeed += 0.1f;
        }
    }
}
