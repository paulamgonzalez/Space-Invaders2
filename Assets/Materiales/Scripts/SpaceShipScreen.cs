using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


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

    public float speed = 1;
    public int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        speedSlider.value = 0;
        heatSlider.value = 0;
        shieldSlider.value = 0;
        spaceName.text = infoSpaceShip[index].spaceshipname;

        Debug.Log("speed" + infoSpaceShip[index].speed);
        Debug.Log("heat" + infoSpaceShip[index].heat);
        Debug.Log("shield" + infoSpaceShip[index].shield);
        Debug.Log("spaceName" + infoSpaceShip[index].spaceshipname);


    }

    // Update is called once per frame
    void Update()
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


        if (shieldSlider.value < infoSpaceShip[index].shield)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

        if (heatSlider.value < infoSpaceShip[index].heat)
        {
            heatSlider.value += Time.deltaTime * speed;
        }

        if (speedSlider.value < infoSpaceShip[index].speed)
        {
            speedSlider.value += Time.deltaTime * speed;
        }

    }

    public void NextShip()
    {
        index++;
        if (index > 2)
        {
            index = 0;
        }
        shieldSlider.value = 0;
        heatSlider.value = 0;
        speedSlider.value = 0;
    }

    public void PreviousShip()
    {
        index--;
        if (index < 0)
        {
            index = 2;
        }
        shieldSlider.value = 0;
        heatSlider.value = 0;
        speedSlider.value = 0;
    }

}
