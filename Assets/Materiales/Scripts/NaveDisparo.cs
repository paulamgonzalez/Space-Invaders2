using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveDisparo : MonoBehaviour
{
    public GameObject projectilePrefab;

    Rigidbody rigidbody3d;

    Vector3 lookDirection = new Vector3(0, 1);

    float timer;

    bool timerDisparo;

    float speedAtaque;

    private void Start()
    {
        rigidbody3d = GetComponent<Rigidbody>();

        speedAtaque = GameDataPersistent.instance.selectedSpaceship.heat;


    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            Launch();
        }
    }

    void TiempoEspera()
    {
        
    }

    

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody3d.position + Vector3.up * 15.5f, Quaternion.identity);

        ProyectilController projectile = projectileObject.GetComponent<ProyectilController>();

        projectile.Disparo(lookDirection, 300);
    }
}
