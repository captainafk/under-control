using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMng : MonoBehaviour
{
    // TODO: Implement change button color on click
    public void ActivateButton(GameObject number, int opIndex)
    {
        GameObject pressedButton = number.transform.GetChild(opIndex).gameObject;
        TextMeshProUGUI opText = pressedButton.GetComponentInChildren<TextMeshProUGUI>();
        opText.color = Color.green;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
