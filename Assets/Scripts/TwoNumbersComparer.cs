using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField FirstNumber;
    [SerializeField] private InputField SecondNumber;
    [SerializeField] private Text ResultText;

    void Start()
    {
        
    }

    public void CompareTwo()
    {
        if (FirstNumber.text != "" && SecondNumber.text != "")
        {
            float FirstNum = float.Parse(FirstNumber.text);
            float SecondNum = float.Parse(SecondNumber.text);
            if (FirstNum == SecondNum)
            {
                ResultText.text = "Равны";
            } 
            else
            {
                ResultText.text = $"{(FirstNum > SecondNum ? FirstNumber.text : SecondNumber.text)}";
            }
            
        }
        else
        {
            ResultText.text = "Введите оба числа!";
        }
    }
}
