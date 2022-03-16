using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProyectilController : MonoBehaviour
{
    Rigidbody rigidbody3d;


    public PointsManage pointsManage;

    public GameObject enemigo1;
    public GameObject enemigo2;
    public GameObject enemigo3;

    int enemigoPoint1 = 10;
    int enemigoPoint2 = 20;
    int enemigoPoint3 = 30;

    

    

    float speedAtaque;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody3d = GetComponent<Rigidbody>();

        //puntosLabel.text = puntosActuales.ToString();
        
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
        
        if (collision.gameObject.tag == "Marcianos") 
        {
            collision.gameObject.SetActive(false);

            

            if (enemigo1 == false)
            {
                pointsManage.puntosActuales += enemigoPoint1;
            }
            if (enemigo2 == false)
            {
                pointsManage.puntosActuales += enemigoPoint2;
            }
            if (enemigo3 == false)
            {
                pointsManage.puntosActuales += enemigoPoint3;
            }
        }
        Destroy(gameObject);// para que se destruya el proyectil y no se quede ahi pegado
    }

   
}
