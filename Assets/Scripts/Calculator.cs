using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField firstOperand;
    [SerializeField] private InputField secondOperand;
    [SerializeField] private Text resultText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void addButtonOnClick()
    {
        if (firstOperand.text != "" && secondOperand.text != "")
        {
            resultText.text = $"{int.Parse(firstOperand.text) + int.Parse(secondOperand.text)}";
        } 
        else
        {
            resultText.text = "¬ведите оба числа!";
        }

    }

    public void substractButtonOnClick()
    {
        if (firstOperand.text != "" && secondOperand.text != "")
        {
            resultText.text = $"{int.Parse(firstOperand.text) - int.Parse(secondOperand.text)}";
        }
        else
        {
            resultText.text = "¬ведите оба числа!";
        }

    }

    public void multiplyButtonOnClick()
    {
        if (firstOperand.text != "" && secondOperand.text != "")
        {
            resultText.text = $"{int.Parse(firstOperand.text) * int.Parse(secondOperand.text)}";
        }
        else
        {
            resultText.text = "¬ведите оба числа!";
        }

    }

    public void divideButtonOnClick()
    {
        if (firstOperand.text != "" && secondOperand.text != "")
        {
            resultText.text = $"{float.Parse(firstOperand.text) / int.Parse(secondOperand.text)}";
        }
        else
        {
            resultText.text = "¬ведите оба числа!";
        }

    }
}
