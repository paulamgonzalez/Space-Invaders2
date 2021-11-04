using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScreen : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject nextScreen;

    public void ChangeeScreen()
    {
        currentScreen.SetActive(false);
        nextScreen.SetActive(true);
    }
}