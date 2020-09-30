using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameMng : MonoBehaviour
{
    // TODO: Implement change button color on click
    public void ActivatePlusButton(GameObject button)
    {
        button.GetComponent<Image>().sprite = Resources.Load<Sprite>("plus3");
    }

    public void ActivateMultButton(GameObject button)
    {
        button.GetComponent<Image>().sprite = Resources.Load<Sprite>("mult3");
    }

    public void ActivateMinusButton(GameObject button)
    {
        button.GetComponent<Image>().sprite = Resources.Load<Sprite>("minus2");
    }

    public void ActivateDivButton(GameObject button)
    {
        button.GetComponent<Image>().sprite = Resources.Load<Sprite>("div2");
    }

    public void DeactivatePlusButton(GameObject button)
    {
        button.GetComponent<Image>().sprite = Resources.Load<Sprite>("plus1");
    }

    public void DeactivateMultButton(GameObject button)
    {
        button.GetComponent<Image>().sprite = Resources.Load<Sprite>("mult1");
    }

    public void DeactivateMinusButton(GameObject button)
    {
        button.GetComponent<Image>().sprite = Resources.Load<Sprite>("minus1");
    }

    public void DeactivateDivButton(GameObject button)
    {
        button.GetComponent<Image>().sprite = Resources.Load<Sprite>("div1");
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}