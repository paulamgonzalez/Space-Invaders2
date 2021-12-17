using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class SpaceShipScreen : MonoBehaviour
{
    public SpaceShipData[] infoSpaceShip;

    public Slider speedSlider;
    public Slider heatSlider;
    public Slider shieldSlider;
    public TextMeshProUGUI spaceName;

    public GameObject nave1;
    public GameObject nave2;
    public GameObject nave3;
    public GameObject[] modeloNaves;

    public AudioSource musica1;
    public AudioSource musica2;
    public AudioSource musicaInicio;
    public GameObject pantallaEleccionNaves;

    public float speed = 1;
    public int index = 0;

    
    // Start is called before the first frame update
    void Start()
    {

        MostrarNaveActual();
        

        Debug.Log("speed" + infoSpaceShip[index].speed);
        Debug.Log("heat" + infoSpaceShip[index].heat);
        Debug.Log("shield" + infoSpaceShip[index].shield);
        Debug.Log("spaceName" + infoSpaceShip[index].spaceshipname);


    }

    // Update is called once per frame
    void Update()
    {
 
        ActualizarSlider(shieldSlider, infoSpaceShip[index].shield);
        ActualizarSlider(heatSlider, infoSpaceShip[index].heat);
        ActualizarSlider(speedSlider, infoSpaceShip[index].speed);

        //para que la musica del anterior script pare y siga la cancion normal en la siguiente pantalla.

        if(pantallaEleccionNaves == true)
        {
            musica1.Pause();
            musica2.Pause();
            musicaInicio.UnPause();
        }

    }

    public void MostrarNaveActual()
    {

        for (int i = 0; i < modeloNaves.Length; i++)
        {
            if (i == index)
            {
                modeloNaves[i].SetActive(true);
            }
            else
            {
                modeloNaves[i].SetActive(false);
            }
        }
        spaceName.text = infoSpaceShip[index].spaceshipname;
    }

    public void ActualizarSlider(Slider generico, int valor)
    {

        if (generico.value < valor)
        {
            generico.value += Time.deltaTime * speed;
        }
        else if (generico.value > valor)
        {
            generico.value -= Time.deltaTime * speed;
        }

    }

    //Botones 

    public void NextShip()
    {
        index++;
        if (index > 2)
        {
            index = 0;
        }
        MostrarNaveActual();
    }

    public void PreviousShip()
    {
        index--;
        if (index < 0)
        {
            index = 2;
        }
        MostrarNaveActual();

    }

}
