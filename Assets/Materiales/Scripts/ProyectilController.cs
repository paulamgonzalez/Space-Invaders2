using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProyectilController : MonoBehaviour
{
    Rigidbody rigidbody3d;

    int enemigoPoint1 = 10;
    int enemigoPoint2 = 20;
    int enemigoPoint3 = 30;
   int enemigoPointNodriza = 50;
 
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody3d = GetComponent<Rigidbody>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Esto sirve para no tener cientos de projectiles sin colisionar
        if (transform.position.magnitude > 500.0f) //sirve para que si el proyectil no colisiona con nada, se destruya
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

        if (collision.gameObject.tag == "MarcianoAbajo")
        {
            collision.gameObject.SetActive(false);

            PointsManage.puntosActuales += enemigoPoint1;

        }
        if (collision.gameObject.tag == "MarcianoArriba")
        {
            collision.gameObject.SetActive(false);

            PointsManage.puntosActuales += enemigoPoint3;

        }
        if (collision.gameObject.tag == "MarcianoMedio")
        {
            collision.gameObject.SetActive(false);

            PointsManage.puntosActuales += enemigoPoint2;

        }

        if (collision.gameObject.tag == "MarcianoNodriza")
        {
            collision.gameObject.SetActive(false);

            PointsManage.puntosActuales += enemigoPointNodriza;

        }
 
        Destroy(gameObject);// para que se destruya el proyectil y no se quede ahi pegado
    }

   
}
