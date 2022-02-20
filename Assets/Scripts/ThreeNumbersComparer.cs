using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField FirstNumber;
    [SerializeField] private InputField SecondNumber;
    [SerializeField] private InputField ThirdNumber;
    [SerializeField] private Text ResultText;

    void Start()
    {

    }

    public void CompareThree()
    {
        if (FirstNumber.text != "" && SecondNumber.text != "" && ThirdNumber.text != "")
        {
            float FirstNum = float.Parse(FirstNumber.text);
            float SecondNum = float.Parse(SecondNumber.text);
            float ThirdNum = float.Parse(ThirdNumber.text);
            float FirstMax, SecondMax;

            if (FirstNum == SecondNum && SecondNum == ThirdNum)
            {
                ResultText.text = "Все числа равны!";
            }
            else
            {
                if (FirstNum >= SecondNum)
                {
                    FirstMax = FirstNum;
                    SecondMax = SecondNum >= ThirdNum ? SecondNum : ThirdNum;
                }
                else
                {
                    FirstMax = SecondNum;
                    SecondMax = ThirdNum;
                }

                ResultText.text = $"{FirstMax} {SecondMax}";
            }

        }
        else
        {
            ResultText.text = "Введите все три числа!";
        }
    }
}
