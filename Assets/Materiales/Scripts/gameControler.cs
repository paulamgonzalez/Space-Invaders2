using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameControler : MonoBehaviour
{

    public static gameControler instance;

    public GameObject introScreen;
    public GameObject pressAnyButtonScreen;
    public GameObject pantallaInicial;

    private float cronometro = 0.0f;

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
        //Que cuando el texto desaparezca se cambie a la segunda pantalla
            if(cronometro>=76.55f)
            {
                gameControler.instance.EnableScreenAnybutton();
            }
        //Que cambie a la segunda pantalla al dar espacio
           else if(Input.GetKeyDown(KeyCode.Space))
            {
                gameControler.instance.EnableScreenAnybutton();
            }
    }


    //Entrar a la pantalla de espera
    public void EnableScreenAnybutton()
    {
        introScreen.SetActive(false);
        pressAnyButtonScreen.SetActive(true);       
    }

    public void EnablePantallaInicial()
    {
        pressAnyButtonScreen.SetActive(false);
        pantallaInicial.SetActive(true);
    }
}
