using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public void Awake()
    {
        GameObject nave = Instantiate(GameDataPersistent.instance.sekectedSpaceship.prefab);
        nave.transform.localScale *= 10f;
    }
}
