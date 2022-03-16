using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsManage : MonoBehaviour
{
    

   

    public int puntosActuales = 0;

    public TextMeshProUGUI puntosLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        puntosLabel.text = puntosActuales.ToString();
    }

    
        

    
}
