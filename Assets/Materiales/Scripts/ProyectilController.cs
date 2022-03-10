using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilController : MonoBehaviour
{
    Rigidbody rigidbody3d;

    float speedAtaque;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody3d = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Esto sirve para no tener cientos de projectiles sin colisionar
        if (transform.position.magnitude > 1000.0f) //sirve para que si el proyectil no colisiona con nada, se destruya
        {
            Destroy(gameObject);
        }
    }

    public void Disparo(Vector3 up, float force)
    {
        rigidbody3d.AddForce(up * force * 10f);
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Marcianos") //si e no esta vacio (e haciendo referecnia al enemigo)
        {
            collision.gameObject.SetActive(false);
        }
        Destroy(gameObject);// para que se destruya el proyectil y no se quede ahi pegado
    }

   
}
