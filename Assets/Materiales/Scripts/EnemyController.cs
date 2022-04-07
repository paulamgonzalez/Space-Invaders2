using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class EnemyController : MonoBehaviour
{
    float timeEnemigo;
    bool disparoEnemigo = false;

    Vector3 naveGrandePos = new Vector3(402.7f, 70f);
    public GameObject naveGrande;
    float timerNaveGrande = 10f;
    float timerNaveGrandeMin = 10f;
    float timerNaveGrandeMax = 20f;

    public GameObject pantallaGanaste;

    public float timer = 0f;
    public float timeToMove = 3f;
    public float speed = 0.5f;
    public int numeroMovimienos = 0;

    public static EnemyController instance;

    [Serializable]

    
    public class EnemiesList //esto es un array dentro de un array
    {
        public GameObject[] enemies;
    }
    public EnemiesList[] enemiesList;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        PrintArray();//Llamamos a la funcion que revisa la array

        pantallaGanaste.SetActive(false);
       
    }

    void Update()
    {
        MovimientoNaveGrande(); 

        VictoryScreen();

        MovimientoEnemigos();
    }

    
    void PrintArray() //Array de los enemigos
    {
        for (int x = 0; x < enemiesList.Length; x++) //esto es apara q mire en horizontal la array (filas)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++) //esto es para que mire en verical la array (columnas)
            {
                if (enemiesList[x].enemies[y].activeSelf == true) //Si el enemigo de la posicion xy esta activo entonces di el nombre
                {
                   
             
                }
                

            }   
        }
    } 

    public void Attack() //Funcion ataque de los enemigos
    {

        //selecc columna aleatoria
        int randomColumna = UnityEngine.Random.Range(0, enemiesList.Length);
        Debug.Log("columna que va a atacar" + randomColumna);


        //Busca el ultimo activo de la columna
        GameObject[] columnaAttack = enemiesList[randomColumna].enemies;
        int row = -1;
        for (int y = 0; y<columnaAttack.Length; y++)
        {
            if(columnaAttack[y].activeSelf == true)
            {
                row = y;
                
            }          
        }

        if(row != -1) // pa que no ataquen si estan muertops
        {
            columnaAttack[row].GetComponent<EnemieAttack>().Ataque();
        }


    } 

    public void MovimientoEnemigos()
    {
        for (int x = 0; x < enemiesList.Length; x++) //esto es apara q mire en horizontal la array (filas)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++) //esto es para que mire en verical la array (columnas)
            {
                if (enemiesList[x].enemies[y].activeSelf == true) //Si el enemigo de la posicion xy esta activo entonces di el nombre
                {

                    timer += Time.deltaTime;
                    if (timer > timeToMove)
                    {
                        transform.position += (new Vector3(speed, 0, 0));
                        timer = 0;
                        numeroMovimienos++;
                    }
                }


            }
        }
    }

    public void SpawnNaveGrande() //Funcion aparicion Nave Nodriza 
    {
        Instantiate(naveGrande, naveGrandePos, Quaternion.identity); //el instantiate sirve para clonar el objeto del prefab y hacerlo aparecer en pantalla, ademas podemos decirle como queremos que aparezca, en este caso el quaternion lo usamos para eso .
        timerNaveGrande = UnityEngine.Random.Range(timerNaveGrandeMin, timerNaveGrandeMax);

        naveGrande.SetActive(true);
        naveGrande.transform.localPosition = new Vector3(402.7f, 70f);
    } 

    public void MovimientoNaveGrande()
    {
        timeEnemigo -= Time.deltaTime;
        timerNaveGrande -= Time.deltaTime;
        if (timerNaveGrande <= 0)
        {
            SpawnNaveGrande();
        }

        if (timeEnemigo <= 0)
        {
            disparoEnemigo = true;
            Attack();

        }

        if (disparoEnemigo == true)
        {
            timeEnemigo = 2f;
            disparoEnemigo = false;
        }

    } //Funcion movimiento nave nodriza

    public void VictoryScreen() //Funcion Pantalla Victoria
    {
         int numeroEnemigos = 44;

        for (int x = 0; x < enemiesList.Length; x++) //esto es apara q mire en horizontal la array (filas)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++) //esto es para que mire en verical la array (columnas)
            {
                if (enemiesList[x].enemies[y].activeSelf == false) //Si el enemigo de la posicion xy esta activo entonces di el nombre
                {
                    numeroEnemigos -= 1;
                }

                if(numeroEnemigos <= 0)
                {
                    pantallaGanaste.SetActive(true);
                    naveGrande.SetActive(false);
                }
            }
        }


    }

    public void ChoqueEnBarrea()
    {
        transform.Translate(new Vector3(0, -0.5f, 0));
        numeroMovimienos = -1;
        speed = -speed;
        timer = 0;
    }

    public void OnCollisionEnter(Collision collision) 
    {
        

        if (collision.gameObject.tag == "TopeIzq")
        {
            transform.Translate(new Vector3(0, -0.5f, 0));
            numeroMovimienos = -1;
            speed = -speed;
            timer = 0;
        }
        
    }

    
}
