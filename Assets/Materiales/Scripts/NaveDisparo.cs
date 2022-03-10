using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveDisparo : MonoBehaviour
{
    public GameObject projectilePrefab;

    Rigidbody rigidbody3d;

    Vector3 lookDirection = new Vector3(0, 1);



    bool boolDisparo = false;

    float speedAtaque;

    private void Start()
    {
        rigidbody3d = GetComponent<Rigidbody>();

        speedAtaque = GameDataPersistent.instance.selectedSpaceship.heat;

        speedAtaque = 0; 


    }
    // Update is called once per frame
    void Update()
    {

        speedAtaque -= Time.deltaTime;


        if (speedAtaque <= 0 && Input.GetKey(KeyCode.I))
        {
            Launch();
            boolDisparo = true;
        }

        if (boolDisparo == true)
        {
            speedAtaque = GameDataPersistent.instance.selectedSpaceship.heat;
            boolDisparo = false;
        }

    }


    //Tiempo entre disparo
    /*public void TiempoEspera()
    {
        if(speedAtaque <= 0 && Input.GetKey(KeyCode.I))
        {
            Launch();
            boolDisparo = true;
        }
        else if(boolDisparo == true)
        {
            speedAtaque = GameDataPersistent.instance.selectedSpaceship.heat;
            boolDisparo = false;
        }       
    }*/

    

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody3d.position + Vector3.up * 15.5f, Quaternion.identity);

        ProyectilController projectile = projectileObject.GetComponent<ProyectilController>();

        projectile.Disparo(lookDirection, 300);
    }
}
