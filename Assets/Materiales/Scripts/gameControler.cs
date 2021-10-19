using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameControler : MonoBehaviour
{

    public static gameControler instance;

    public GameObject introScreen;
    public GameObject pressAnyButtonScreen;
    // Start is called before the first frame update

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gameControler.instance.EnterIntro();
        }
    }

    public void EnterIntro()
    {
        introScreen.SetActive(false);
        pressAnyButtonScreen.SetActive(true);
    }
}
