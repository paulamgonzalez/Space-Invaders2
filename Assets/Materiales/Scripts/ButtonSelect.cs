using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonSelect : MonoBehaviour
{
    public Button selectedButton;
    // Start is called before the first frame update
    public void OnEnable()
    {
        selectedButton.Select();
    }

    
}
