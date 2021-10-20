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
        cronometro += Time.deltaTime;
        //Que cuando el texto desaparezca se cambie a la segunda pantalla
            if (cronometro>=77.0f)
            {               
                gameControler.instance.EnableScreenAnybutton();
            }

        //Que cambie a la segunda pantalla al dar espacio
           else if(Input.GetKeyDown(KeyCode.Space))
           {
                gameControler.instance.EnableScreenAnybutton();
           }

        //Que cuando le des a cualquier tecla se cambie a una tercera pantalla
           if(Input.GetKeyDown(KeyCode.Escape))
           {
                gameControler.instance.EnablePantallaInicial();
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
