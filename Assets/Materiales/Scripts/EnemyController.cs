using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
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
        if (Input.GetKeyUp(KeyCode.Space)) //toda esta movida es porq el tema del disparo es muy similar
        {
            int lastX = enemiesList.Length - 1;
            int lastY = enemiesList[lastX].enemies.Length - 1;
            bool foundLastActive = false;
            //ejer
            for (int x = 0; x < enemiesList.Length; x++)
            {
                for (int y = 0; y < enemiesList[x].enemies.Length; y++)
                {
                    if (enemiesList[x].enemies[y].activeSelf == false && foundLastActive == false) //para
                    {
                        foundLastActive = true;
                    }
                    else if (enemiesList[x].enemies[y].activeSelf == true && foundLastActive == false) // dice cual es el ultimo
                    {
                        lastX = x;
                        lastY = y;








                    }

                }
            }

            //desactiva el enemigo final
            enemiesList[3].enemies[enemiesList[3].enemies.Length - 1].SetActive(false); //los enemigos se desactivan no se destruyen
            PrintArray();
        }


    }


}
