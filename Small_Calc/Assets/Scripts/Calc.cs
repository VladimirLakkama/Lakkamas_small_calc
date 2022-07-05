using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calc : MonoBehaviour
{
    
    private float inputOne;
    private float inputTwo;
    private float result;
    private string operation;
    public InputField inputField;

    public void onClick()
    {

        inputField.text = inputOne.ToString();

    }


}
