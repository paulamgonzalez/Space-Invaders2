using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameControler : MonoBehaviour
{

    public static gameControler instance;

    //pantallas 
    public GameObject introScreen;
    public GameObject pressAnyButtonScreen;
    public GameObject pantallaInicial;
    public GameObject pantallaOpciones;
    public GameObject screenRecords;
    public GameObject screenGame;
    public GameObject screenGame2;
    public GameObject screenGame3;

    public string SceneName;


    public GameObject texto3d;
    
    

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
            if (cronometro >= 83.0f)
            {
                texto3d.SetActive(false);
                gameControler.instance.EnableScreenAnybutton();
            }
            //Que cambie a la segunda pantalla al dar espacio
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                texto3d.SetActive(false);
                gameControler.instance.EnableScreenAnybutton();
            }
        }         
        else if (pressAnyButtonScreen.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
        {
            texto3d.SetActive(false);
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
        screenGame.SetActive(false);
    }

    public void EnablePantallaOpciones()
    {
        pantallaInicial.SetActive(false);
        pantallaOpciones.SetActive(true);
        screenGame.SetActive(false);
    }

   public void EnablePantallaRecords()
    {
        pantallaInicial.SetActive(false);
        screenRecords.SetActive(true);
    }

    public void EnablePantallaGame()
    {
        pantallaInicial.SetActive(false);
        screenGame.SetActive(true);
    }

    public void EnablePantallaGame2()
    {
        screenGame.SetActive(false);
        screenGame2.SetActive(true);
    }

    public void DisablePantallaGame2()
    {
        screenGame2.SetActive(false);
        screenGame.SetActive(true);
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene(SceneName);
        screenGame2.SetActive(false);
    }


    
}
