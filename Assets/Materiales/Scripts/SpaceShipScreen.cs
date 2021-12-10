using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceShipScreen : MonoBehaviour
{
    public SpaceShipData infoSpaceShip;

    public Slider speedSlider;
    public Slider heatSlider;
    public Slider shieldSlider;
    public TextMeshProUGUI spaceName;

    public GameObject nave1;
    public GameObject nave2;
    public GameObject nave3;

    public float speed = 1;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        speedSlider.value = 0;
        heatSlider.value = 0;
        shieldSlider.value = 0;
        spaceName.text = infoSpaceShip.spaceshipname;

        Debug.Log("speed" + infoSpaceShip.speed);
        Debug.Log("heat" + infoSpaceShip.heat);
        Debug.Log("shield" + infoSpaceShip.shield);
        Debug.Log("spaceName" + infoSpaceShip.spaceshipname);
    }

    // Update is called once per frame
    void Update()
    {
       
        spaceName.text = infoSpaceShip.spaceshipname;


        if (shieldSlider.value < infoSpaceShip.shield)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

        if (heatSlider.value < infoSpaceShip.heat)
        {
            heatSlider.value += Time.deltaTime * speed;
        }

        if (speedSlider.value < infoSpaceShip.speed)
        {
            speedSlider.value += Time.deltaTime * speed;
        }

        if (index == 0)
        {
            nave1.SetActive(true);
            nave2.SetActive(false);
            nave3.SetActive(false);
        }
        if (index == 1)
        {
            nave2.SetActive(true);
            nave1.SetActive(false);
            nave3.SetActive(false);
        }
        if (index == 2)
        {
            nave3.SetActive(true);
            nave2.SetActive(false);
            nave1.SetActive(false);
        }
    }
}
