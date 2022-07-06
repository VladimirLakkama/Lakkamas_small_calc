using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleCalculator : MonoBehaviour

{

    public InputField strokaA;
    public InputField strokaB;
    public Text result;

    public void Summ()
    {
        float a, b, c;
        a = float.Parse(strokaA.text);
        b = float.Parse(strokaB.text);
        c = a + b;

        result.text = c.ToString();

     }

    public void Mines()
    {
        float a, b, c;
        a = float.Parse(strokaA.text);
        b = float.Parse(strokaB.text);
        c = a - b;

        result.text = c.ToString();

    }

    public void Umnogit()
    {
        float a, b, c;
        a = float.Parse(strokaA.text);
        b = float.Parse(strokaB.text);
        c = a * b;

        result.text = c.ToString();

    }

    public void Delit()
    {
        if (strokaB.text != 0.ToString())
        {
            float a, b, c;
            a = float.Parse(strokaA.text);
            b = float.Parse(strokaB.text);
            c = a / b;
            result.text = c.ToString();
        }
        else 
        {
            result.text = "нельзя делить на ноль".ToString();
        }
        
    }


}
