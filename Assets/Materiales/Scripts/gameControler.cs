using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameControler : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject pressAnyButtonScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void EnterGame()
    {
        introScreen.SetActive(false);
        pressAnyButtonScreen.SetActive(true);
    }
}
