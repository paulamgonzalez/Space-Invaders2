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

    float timer = 0;
    float timerMove = 0.5f;
    int numeroMovimientos = 0;
    float speed = 2f;

    public int numeroEnemigos = 0;


    bool victoria = false;
    


    [Serializable]

    
    public class EnemiesList //esto es un array dentro de un array
    {
        public GameObject[] enemies;
    }
    public EnemiesList[] enemiesList;

   
    void Start()
    {
        PrintArray();//Llamamos a la funcion que revisa la array

        pantallaGanaste.SetActive(false);
       
    }

    
    

    
    void Update()
    {
        //numeroEnemigos = enemiesList.Length;
       /* if (victoria == true && numeroEnemigos == 0)
        {
            pantallaGanaste.SetActive(true);
            naveGrande.SetActive(false);
        }*/

        //Movimiento marcianos
        if (numeroMovimientos == 14) //Movimiento hacia abajo
        {
            transform.Translate(new Vector3(0, -1, 0));
            speed = -speed;
            numeroMovimientos = -1;
            timer = 0;
        }
        timer += Time.deltaTime;
        if(timer > timerMove && numeroMovimientos <14)//Movimiento hacia un lado
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numeroMovimientos++;
            
        }
        


        //Movimiento nave nodriza
        timeEnemigo -= Time.deltaTime;
        timerNaveGrande -= Time.deltaTime;
        if(timerNaveGrande <=0)
        {
            SpawnNaveGrande();
        }

        if(timeEnemigo <= 0)
        {
            disparoEnemigo = true;
            Attack();

        }

        if(disparoEnemigo == true)
        {
            timeEnemigo = 2f;
            disparoEnemigo = false;
        }


        VictoryScreen();

        
        
    }

    //Hacemos un bucle para q mire toda la array
    void PrintArray()
    {
        for (int x = 0; x < enemiesList.Length; x++) //esto es apara q mire en horizontal la array (filas)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++) //esto es para que mire en verical la array (columnas)
            {
                if (enemiesList[x].enemies[y].activeSelf == true) //Si el enemigo de la posicion xy esta activo entonces di el nombre
                {
                    numeroEnemigos++;
             
                }
                else
                {
                    numeroEnemigos -= 1;
                }

            }   
        }
    }

    public void Attack()
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
            else if(columnaAttack[y].activeSelf == false)
            {
                numeroEnemigos--;
            }
             
            
        }

        if(row != -1) // pa que no ataquen si estan muertops
        {
            columnaAttack[row].GetComponent<EnemieAttack>().Ataque();
        }


    }

    public void SpawnNaveGrande()
    {
        Instantiate(naveGrande, naveGrandePos, Quaternion.identity);
        timerNaveGrande = UnityEngine.Random.Range(timerNaveGrandeMin, timerNaveGrandeMax);

        naveGrande.SetActive(true);
        naveGrande.transform.localPosition = new Vector3(402.7f, 70f);
    }


    public void VictoryScreen()
    {


        if(numeroEnemigos <= 0)
        {

            pantallaGanaste.SetActive(true);
            naveGrande.SetActive(false);
            victoria = true;
        }


    }

}
