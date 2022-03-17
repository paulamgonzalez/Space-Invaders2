using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
    float timeEnemigo;
    bool disparoEnemigo = false;

    Vector3 naveGrandePos = new Vector3(402.7f, 70f);
    public GameObject naveGrande;
    float timerNaveGrande = 10f;
    float timerNaveGrandeMin = 10f;
    float timerNaveGrandeMax = 20f;



    [Serializable]

    
    public class EnemiesList //esto es un array dentro de un array
    {
        public GameObject[] enemies;
    }
    public EnemiesList[] enemiesList;

    //Llamamos a la funcion que revisa la array
    void Start()
    {
        PrintArray();
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
                    //Debug.Log(enemiesList[x].enemies[y].name);
                }

            }
        }
    }

    //hacer bucle con x e y, que almacene la ultima x e y donde esta el enemigo activo
    //Cuando el enemigo se desactive dejar de contar
    //Desactivar el enemylist[x] y el enemies[y]
    void Update()
    {

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

        
    }



    public void Attack()
    {

        //selecc columna aleatoria
        int randomColumna = UnityEngine.Random.Range(0, enemiesList.Length);
        Debug.Log("columna que va a atacar" + randomColumna);


        //Busca el ultimo activo de la columna
        GameObject[] columnaAttack = enemiesList[randomColumna].enemies;
        int row = 0;
        for (int y = 0; y<columnaAttack.Length; y++)
        {
            if(columnaAttack[y].activeSelf == true)
            {
                row = y;
            }
            
        }

        if(row != -1)
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


}
