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
        if (introScreen.activeSelf == true)
        {
            cronometro += Time.deltaTime;
            //Que cuando el texto desaparezca se cambie a la segunda pantalla
            if (cronometro >= 77.0f)
            {
                gameControler.instance.EnableScreenAnybutton();
            }
            //Que cambie a la segunda pantalla al dar espacio
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                gameControler.instance.EnableScreenAnybutton();
            }
        }         
        else if (pressAnyButtonScreen.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
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
