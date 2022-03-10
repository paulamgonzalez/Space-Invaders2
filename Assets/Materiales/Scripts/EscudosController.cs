using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudosController : MonoBehaviour
{
    int collisionCount;
    int duracion;

    public GameObject escudo;
    public GameObject escudoRoto1;
    public GameObject escudoRoto2;

    // Start is called before the first frame update
    void Start()
    {
        duracion = GameDataPersistent.instance.selectedSpaceship.shield;
        collisionCount = duracion;

        escudo.SetActive(true);
        escudoRoto1.SetActive(false);
        escudoRoto2.SetActive(false);

    }

    // Update is called once per frame
    
    public void OnCollisionEnter(Collision collision)
    {
        
        collisionCount--;

        Debug.Log(collisionCount);
       
        /*if(collisionCount == 2)
        {
            escudo.SetActive(false);
            escudoRoto1.SetActive(true);
        }
        if(collisionCount == 1)
        {
            escudoRoto2.SetActive(true);
            escudoRoto1.SetActive(false);            
        }*/

        if (collisionCount == 0)
        {
            //escudoRoto1.SetActive(false);
           // escudoRoto2.SetActive(false);
            escudo.SetActive(false);
        }
    }
}

