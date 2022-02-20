using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChanger : MonoBehaviour
{
    [SerializeField] private GameObject calculatorScreen;
    [SerializeField] private GameObject comparingTwoScreen;
    [SerializeField] private GameObject comparingThreeScreen;
    private GameObject currentScreen;

    private void Start()
    {
        calculatorScreen.SetActive(true);
        comparingTwoScreen.SetActive(false);
        currentScreen = calculatorScreen;
        Debug.Log("Start!");
    }

    public void ChangeScreen(GameObject screen)
    {
        if (currentScreen != null)
        {
            Debug.Log($"Change {currentScreen} to {screen}");
            currentScreen.SetActive(false);
            screen.SetActive(true);
            currentScreen = screen;
        }
    }

}
