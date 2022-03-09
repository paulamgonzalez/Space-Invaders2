using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
    [Serializable]

  public class EnemiesList
  {
   public GameObject[] enemies;
  }

    public EnemiesList[] enemiesList;





    // Start is called before the first frame update
    void Start()
    {
        PrintArray();
    }

    public void PrintArray()
    {
        for (int x = 0; x < enemiesList.Length; x++)//recorrer array
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)
            {
                if (enemiesList[x].enemies[y].activeSelf == true)//activa ese elemento
                {
                    enemiesList[3].enemies[enemiesList[3].enemies.Length - 1].SetActive(false);//desactiva el enemigo colocando en la posicion x e y
                    Debug.Log(enemiesList[x].enemies[y].name);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
            //desactiva el enemigo colocando en la posicion x e y
            
            PrintArray();
    }

   
}
