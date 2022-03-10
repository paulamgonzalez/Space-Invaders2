using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoShips : MonoBehaviour
{

    float speedd;



    // Start is called before the first frame update
    public void Start()
    {
       speedd = GameDataPersistent.instance.selectedSpaceship.speed;
    }

    // Update is called once per frame
    void Update()
    {

        //Creamos una variable con la que podremos movernos usando las flechas unicamente en horizontal
        float horizontal = Input.GetAxis("Horizontal");

        
        //creamos una variable vector 2 para que almacene la posicion de la nave seleccionada
        Vector2 position = transform.position;


        //como solo queremos que se mueva en x pues solo usaremos position.x, estamos diciendole que la posicion en x es igual a la posicion en x mas 0.1 es decir que por cada frame se movera 0.1 por
        //horizontal, de esa manera si presionas la izquierda ira en negativo y viceversa, y en caso de no tocar ninguna tecla se quedara en su posicion. Por ultimo lo multiplicamos por la velocidad
        //ya enteriormente establecida para las naves
        position.x = position.x + 0.1f * horizontal * speedd;


        //por ultimo con esta linea actualizamos la nueva posicion de la nave 
        transform.position = position;
        
    }

    
}
