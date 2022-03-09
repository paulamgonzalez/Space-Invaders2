using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveDisparo : MonoBehaviour
{
    public GameObject projectilePrefab;

    Rigidbody rigidbody3d;

    Vector3 lookDirection = new Vector3(1, 0);
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I))
        {
            Launch();
        }
    }

    

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody3d.position + Vector3.up * 0.5f, Quaternion.identity);

        ProyectilController projectile = projectileObject.GetComponent<ProyectilController>();

        projectile.Disparo(lookDirection, 300);
    }
}
