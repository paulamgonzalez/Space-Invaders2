using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemieAttack : MonoBehaviour
{

    public GameObject enemigoBala;
    Vector3 lookDirection = new Vector3(0, -1);
    Rigidbody rigidbodyEnemigo;

    
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyEnemigo = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ataque()
    {
        GameObject projectileObject = Instantiate(enemigoBala, rigidbodyEnemigo.position + Vector3.down * 1f, Quaternion.identity);
        ProyectilController projectile = projectileObject.GetComponent<ProyectilController>();
        projectile.Disparo(lookDirection, 300);
    }

    

}
