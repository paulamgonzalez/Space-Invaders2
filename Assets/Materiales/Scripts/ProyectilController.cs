using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilController : MonoBehaviour
{
    Rigidbody rigidbody3d;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody3d = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Esto sirve para no tener cientos de projectiles sin colisionar
        if (transform.position.magnitude > 150.0f) //sirve para que si la tuerca no colisiona con nada, se destruya
        {
            Destroy(gameObject);
        }
    }

    public void Disparo(Vector3 direction, float force)
    {
        rigidbody3d.AddForce(direction * force);
    }

    void OnCollisionEnter(Collision collision)
    {
        EnemyController e = collision.collider.GetComponent<EnemyController>();
        if (e != null) //si e no esta vacio (e haciendo referecnia al enemigo)
        {
            e.PrintArray();
        }
    }

   
}
