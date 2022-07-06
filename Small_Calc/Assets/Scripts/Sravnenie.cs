using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sravnenie : MonoBehaviour
{

    public InputField strokaA;
    public InputField strokaB;
    public Text result;

    public void SravnenieChisel()
    {

        float a, b;
        a = float.Parse(strokaA.text);
        b = float.Parse(strokaB.text);
        if (a > b)
        {
            result.text = ">".ToString();
        }
        else if (a < b)
        {
            result.text = "<".ToString();
        }
        else
        {
            result.text = "=".ToString();
        }
    }

}
