using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsManage : MonoBehaviour
{
    

   

    public static int  puntosActuales = 0;

   public static int disparosTotales;
   public static int disparosMalgastados;
   public static int disparosAcertados;

    public static int vidasTotales = 3;

    public TextMeshProUGUI labelAcertados;
    public TextMeshProUGUI labelMalgastados;
    public TextMeshProUGUI labelTotales;
    public TextMeshProUGUI labelVidas;

    public TextMeshProUGUI puntosLabel;

    public static GameObject pantallaPerdiste;
    public GameObject pantallaPerdiste2;

    public static PointsManage instance;

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
        pantallaPerdiste.SetActive(false);

       
    }

    // Update is called once per frame
    public void Update()
    {
        puntosLabel.text = puntosActuales.ToString();

        labelAcertados.text = "Disparos acertados" + disparosAcertados.ToString();
        labelMalgastados.text = "Disparos malgastados" + disparosMalgastados.ToString();
        labelTotales.text = "Disparos totales" + disparosTotales.ToString();

        pantallaPerdiste = pantallaPerdiste2;

        labelVidas.text = "Vidas totales" + vidasTotales.ToString();

        if(vidasTotales <=0)
        {
            pantallaPerdiste.SetActive(true);
            labelVidas.text = "Vidas totales" + vidasTotales.ToString();
        }
    }

    
        

    
}
