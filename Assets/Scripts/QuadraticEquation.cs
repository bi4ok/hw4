using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuadraticEquation : MonoBehaviour
{
    [SerializeField] private InputField FirstNumber;
    [SerializeField] private InputField SecondNumber;
    [SerializeField] private InputField ThirdNumber;
    [SerializeField] private Text ResultText;

    void Start()
    {

    }

    public void QuadraticEquationButton()
    {
        if (FirstNumber.text != "" && SecondNumber.text != "" && ThirdNumber.text != "")
        {
            float a = float.Parse(FirstNumber.text);
            float b = float.Parse(SecondNumber.text);
            float c = float.Parse(ThirdNumber.text);
            float D = b*b - 4*a*c;
            if (D < 0)
            {
                ResultText.text = "Корней нет";
            }
            else
            {
                ResultText.text = D == 0 ? $"D=0, x1/x2 = {-b/(2*a)}" : $"D>0, x1={(-b + Mathf.Sqrt(D)/2*a)}, x2={(-b - Mathf.Sqrt(D) / 2 * a)}";
            }
        }
        else
        {
            ResultText.text = "Введите все три числа!";
        }
    }
}
