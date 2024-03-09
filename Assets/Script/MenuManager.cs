using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject MenuWindow;
    public GameObject OptionWindow;
    public GameObject CreditWindow;

    void Start()
    {
        MenuWindow.SetActive(true);
        OptionWindow.SetActive(false);
        CreditWindow.SetActive(false);
    }

    public void OptionButton()
    {
        MenuWindow.SetActive(false);
        OptionWindow.SetActive(true);
        CreditWindow.SetActive(false);
    }
    public void CreditButton()
    {
        MenuWindow.SetActive(false);
        OptionWindow.SetActive(false);
        CreditWindow.SetActive(true);
    }
    public void ButtonExitToMenu()
    {
        MenuWindow.SetActive(true);
        OptionWindow.SetActive(false);
        CreditWindow.SetActive(false);
    }
}
