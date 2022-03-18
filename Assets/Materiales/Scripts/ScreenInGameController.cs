using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScreenInGameController : MonoBehaviour
{
    public TextMeshProUGUI puntosFinales;


    public GameObject buttonRestart;
    public GameObject buttonMenuprincipal;

    public string SceneNameMenuPrincipal;

    public string SceneNameRestart;


    // Start is called before the first frame update
    void Start()
    {
        puntosFinales.text = "Puntos totales" + PointsManage.puntosActuales.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneNameRestart);
        PointsManage.puntosActuales = 0;
    }

    public void GoMenuPrincipal()
    {
        SceneManager.LoadScene(SceneNameMenuPrincipal);
        PointsManage.puntosActuales = 0;
    }
}
